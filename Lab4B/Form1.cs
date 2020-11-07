using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab4B
{
    public partial class Form1 : Form
    {
        string filePath = string.Empty;
        string fileName = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            if (openHtmlFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openHtmlFile.FileName;
                fileName = filePath.Split('\\')[filePath.Split('\\').Length - 1];
                ChangeFileStatus($"Loaded: {fileName}", Color.Black);
                checkTags.Enabled = true;
            } 
            else
            {
                ChangeFileStatus("Failed Loading File", Color.Red);
            }
            
        }

        private void checkTags_Click(object sender, EventArgs e)
        {
            Stack<string> htmlTags = new Stack<string>();

            string tabs = "";

            if (File.Exists(filePath))
            {
                FileStream fs = null;
                StreamReader sr = null;

                try
                {
                    fs = new FileStream(filePath, FileMode.Open);
                    sr = new StreamReader(fs);

                    while (!sr.EndOfStream)
                    {
                        string input = sr.ReadLine();
                        if (input != "")
                        {
                            string[] values = input.Split('<');

                            foreach (string value in values)
                            {
                                if (!string.IsNullOrWhiteSpace(value))
                                {
                                    string htmlEntity = value.Split('>')[0];
                                    string tag = htmlEntity.Split(' ')[0].ToLower();

                                    if (tag != "")
                                    {
                                        if (value.StartsWith("img") || value.StartsWith("hr") || value.StartsWith("br"))
                                        {
                                            htmlTagsLB.Items.Add($"{tabs}Found non-container tag: <{tag}>");
                                        }
                                        else if (tag.StartsWith("/"))
                                        {
                                            tabs = tabs.Substring(0, tabs.Length - 2);
                                            
                                            // If there is no closing tag for the last tag
                                            if (htmlTags.Peek() != tag.Substring(1))
                                            {
                                                ChangeFileStatus($"{fileName} does not have balanced tags", Color.Red);
                                                return;
                                            } else
                                                htmlTags.Pop();

                                            htmlTagsLB.Items.Add($"{tabs}Found closing tag: <{tag}>");
                                        }
                                        else
                                        {
                                            htmlTagsLB.Items.Add($"{tabs}Found opening tag: <{tag}>");
                                            tabs += "  ";
                                            htmlTags.Push(tag);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ChangeFileStatus("Failed Reading File", Color.Red);
                    MessageBox.Show($"Failed Reading File due to:\n{ex}", "Failed Reading File");
                    checkTags.Enabled = false;
                }
                finally
                {
                    if (fs != null)
                        fs.Close();
                    if (sr != null)
                        sr.Close();
                }
            }
            else
            {
                ChangeFileStatus("No File Selected", Color.Red);
            }
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ChangeFileStatus(string text, Color color)
        {
            fileStatus.ForeColor = color;
            fileStatus.Text = text;
        }
    }
}
