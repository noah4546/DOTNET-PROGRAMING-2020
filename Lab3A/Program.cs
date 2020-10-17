/*
 * Noah Tomkins
 * November 1, 2020
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Main class of the program, this class is the first class to be ran at startup
/// </summary>
namespace Lab3A
{
    class Program
    {
        /// <summary>
        /// Main Program
        /// </summary>
        static void Main()
        {
            List<Media> media = ReadData();

            if (media != null)
            {
                MediaView mediaView = new MediaView(media);
                mediaView.ProcessUserSelection();
            }
        }

        /// <summary>
        /// Reads the data from 'Data.txt' and converts to a list of Media objects
        /// </summary>
        /// <returns>Media List</returns>
        static List<Media> ReadData()
        {
            List<Media> media = new List<Media>();

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                if (File.Exists("../../Data.txt")) //Debug Mode
                    fs = new FileStream("../../Data.txt", FileMode.Open);
                else //Release Mode
                    fs = new FileStream("./Data.txt", FileMode.Open);

                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    //Read line
                    string input = sr.ReadLine();

                    //Parse the values
                    string[] values = input.Split('|');

                    if (values.Length > 1) //Media Infromation
                    {
                        string type = values[0];
                        string title = values[1];

                        if (int.TryParse(values[2], out int year) == false)
                            year = 0;

                        if (type == "BOOK")
                        {
                            string author = values[3];
                            string summary = "";
                            
                            while (!sr.EndOfStream)
                            {
                                input = sr.ReadLine();
                                if (input != "-----")
                                {
                                    if (input == "")
                                        summary += "\n";
                                    else
                                        summary += input;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            media.Add(new Book(title, year, author, summary));
                        }
                        if (type == "MOVIE")
                        {
                            string director = values[3];
                            string summary = "";

                            while (!sr.EndOfStream)
                            {
                                input = sr.ReadLine();
                                if (input != "-----")
                                {
                                    if (input != "")
                                        summary += input;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            media.Add(new Movie(title, year, director, summary));
                        }
                        if (type == "SONG")
                        {
                            string album = values[3];
                            string artist = values[4];

                            media.Add(new Song(title, year, album, artist));
                        }
                    }
                }

            } catch (Exception e)
            {
                Console.WriteLine($"Exeption reading 'Data.txt' due to: {e.Message}");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            } finally
            {
                if (fs != null)
                    fs.Close();
                if (sr != null)
                    sr.Close();
            }

            return media;
        }
    }
}
