/*
 * Noah Tomkins
 * November 1, 2020
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

using System;
using System.Collections.Generic;

/// <summary>
/// Purpose: This class is a view class to display media that the user requests
/// </summary>
namespace Lab3A
{
    class MediaView
    {
        private List<Media> Media { get; set; }

        /// <summary>
        /// Create a new MediaView
        /// </summary>
        /// <param name="media">Media List</param>
        public MediaView(List<Media> media)
        {
            Media = media;
        }

        /// <summary>
        /// Procceses the user selection
        /// </summary>
        public void ProcessUserSelection()
        {
            while (true)
            {
                DisplayMenu();

                string input = Console.ReadLine();
                if ((int.TryParse(input, out int userSelection) == false) || userSelection < 1 || userSelection > 6)
                {
                    Console.WriteLine("Invalid Input please enter a number between 1 and 6");
                    Console.WriteLine("\nPress any key to continue . . .");
                    Console.ReadKey();
                    continue;
                }

                if (userSelection == 1)
                    DisplayMedia(typeof(Book));
                if (userSelection == 2)
                    DisplayMedia(typeof(Movie));
                if (userSelection == 3)
                    DisplayMedia(typeof(Song));
                if (userSelection == 4)
                    DisplayMedia(null); //Display all
                if (userSelection == 5)
                    SearchMedia();
                if (userSelection == 6)
                    break;

                Console.WriteLine("\nPress any key to continue . . .");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Displays the menu to the console
        /// </summary>
        private void DisplayMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Noah's Media Collection");
            Console.WriteLine("=======================");
            Console.ResetColor();
            Console.WriteLine("1. List All Books");
            Console.WriteLine("2. List All Movie");
            Console.WriteLine("3. List All Songs");
            Console.WriteLine("4. List All Media");
            Console.WriteLine("5. Search All Media by Title");

            Console.WriteLine("\n6. Exit Program");

            Console.Write("\nEnter choice:");
        }

        /// <summary>
        /// Display media of specific type (if null show all)
        /// </summary>
        /// <param name="type">Type of Media</param>
        private void DisplayMedia(Type type)
        {
            foreach (Media mediaItem in Media)
                if (mediaItem.GetType() == type || type == null)
                {
                    Console.WriteLine(mediaItem);
                    Console.WriteLine("--------------------");
                }  
        }

        /// <summary>
        /// Search all Media and display Media with matching string
        /// </summary>
        private void SearchMedia()
        {
            Console.Write("Enter a search string: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            foreach (Media mediaItem in Media)
            {
                if (mediaItem.Search(input))
                {
                    Console.WriteLine(mediaItem);
                    if (mediaItem.GetType() == typeof(Book))
                        Console.WriteLine(((Book)mediaItem).Decrypt());
                    else if (mediaItem.GetType() == typeof(Movie))
                        Console.WriteLine(((Movie)mediaItem).Decrypt());
                    Console.WriteLine("--------------------");
                }
            }   
        }
    }
}
