/*
 * Noah Tomkins
 * September 21, 2020
 * 
 * Doctor Who: Doctors and Companions
 * Lists all the doctors and their companions
 * 
 * I, Noah Tomkins, 000790079 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

namespace Lab5B
{
    class Episode
    {
        public string StoryId { get; set; }
        public int Season { get; set; }
        public int SeasonYear { get; set; }
        public string Title { get; set; }

        /// <summary>
        /// Creates a new Episode
        /// </summary>
        /// <param name="storyId">storyId</param>
        /// <param name="season">season number</param>
        /// <param name="seasonYear">season year</param>
        /// <param name="title">title of episode</param>
        public Episode(string storyId, int season, int seasonYear, string title)
        {
            StoryId = storyId;
            Season = season;
            SeasonYear = seasonYear;
            Title = title;
        }
    }
}
