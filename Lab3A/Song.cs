/*
 * Noah Tomkins
 * November 1, 2020
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

/// <summary>
/// Purpose: This class reperents a single song.
///          Decripts the Summary using ROT13
/// </summary>
namespace Lab3A
{
    class Song : Media
    {
        public string Album { get; set; }
        public string Artist { get; set; }

        /// <summary>
        /// Creates a new Song
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="year">Year</param>
        /// <param name="album">Album</param>
        /// <param name="artist">Artist</param>
        public Song(string title, int year, string album, string artist): base(title, year)
        {
            Album = album;
            Artist = artist;
        }

        /// <summary>
        /// Returns a string that repersents the song
        /// </summary>
        /// <returns>song string</returns>
        public override string ToString()
        {
            return $"Song Title: {Title} ({Year})\nAlbum: {Album}  Artist: {Artist}";
        }
    }
}
