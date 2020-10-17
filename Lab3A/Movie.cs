/*
 * Noah Tomkins
 * November 1, 2020
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

/// <summary>
/// Purpose: This class reperents a single movie.
///          Decripts the Summary using ROT13
/// </summary>
namespace Lab3A
{
    class Movie : Media, IEncryptable
    {
        public string Director { get; set; }
        public string Summary { get; set; }

        /// <summary>
        /// Creates a new Movie
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="year">Year</param>
        /// <param name="director">Director</param>
        /// <param name="summary">Summary</param>
        public Movie(string title, int year, string director, string summary): base(title, year)
        {
            Director = director;
            Summary = summary;
        }

        /// <summary>
        /// Encrypts string using ROT13
        /// </summary>
        /// <returns>Encrypted string</returns>
        public string Encrypt()
        {
            return null;
        }

        /// <summary>
        /// Decrypts string using ROT13
        /// </summary>
        /// <returns>Decrypted string</returns>
        public string Decrypt()
        {
            char[] summary = Summary.ToCharArray();

            for (int i = 0; i < summary.Length; i++)
            {
                int number = (int)summary[i];

                if (number >= 'a' && number <= 'z')
                    if (number > 'm')
                        number -= 13;
                    else
                        number += 13;
                else if (number >= 'A' && number <= 'Z')
                    if (number > 'M')
                        number -= 13;
                    else
                        number += 13;
                summary[i] = (char)number;
            }

            return new string(summary);
        }

        /// <summary>
        /// Returns a string that repersents the movie
        /// </summary>
        /// <returns>movie string</returns>
        public override string ToString()
        {
            return $"Movie Title: {Title} ({Year})\nDirector: {Director}";
        }
    }
}
