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
    class Companion
    {
        public string Name { get; set; }
        public string Actor { get; set; }
        public int DoctorId { get; set; }
        public string StoryId { get; set; }

        /// <summary>
        /// Creats a new Companion
        /// </summary>
        /// <param name="name">charcters name</param>
        /// <param name="actor">actors name</param>
        /// <param name="doctorId">id of the accompaning doctor</param>
        /// <param name="storyId">storyId of the first apperance</param>
        public Companion(string name, string actor, int doctorId, string storyId)
        {
            Name = name;
            Actor = actor;
            DoctorId = doctorId;
            StoryId = storyId;
        }
    }
}
