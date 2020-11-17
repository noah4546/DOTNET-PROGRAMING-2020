using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_AllOnesAndZeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            asciiTextBox.ResetText();

            for (int i = 0; i <= 127; i++)
            {
                string outputText = String.Format("{0,-8}{1,8}{2,9:X2}{3,12}\r\n", i, (char)i, i,
                                            Convert.ToString(i, 2).PadLeft(8, '0'));
                asciiTextBox.AppendText(outputText);
            }
         
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string encrypt = "";

            for (int i = 0; i < clearStringTB.TextLength; i++)
            {
                char c = clearStringTB.Text[i];
                encrypt += (char)(c + 1);
            }

            encryptStringTB.Text = encrypt;
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            string encrypt = "";

            for (int i = 0; i < clearStringTB.TextLength; i++)
            {
                char c = clearStringTB.Text[i];
                encrypt += (char)(c - 1);
            }

            encryptStringTB.Text = encrypt;
        }

        private void hashBtn_Click(object sender, EventArgs e)
        {
            SHA512Managed sha = new SHA512Managed();
            byte[] input = Encoding.UTF8.GetBytes(clearStringTB.Text);
            byte[] output = sha.ComputeHash(input);
            hashedTB.Text = Convert.ToBase64String(output);

            //salt the hash
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] randomSalt = new byte[32];
            rng.GetBytes(randomSalt);
            string salt = Convert.ToBase64String(randomSalt);

            //hash and salt input
            input = Encoding.UTF8.GetBytes(clearStringTB.Text + salt);
            output = sha.ComputeHash(input);
            hashSaltTB.Text = Convert.ToBase64String(output);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
