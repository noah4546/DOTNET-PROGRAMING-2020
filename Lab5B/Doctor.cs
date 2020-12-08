using System.Drawing;

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
    class Doctor
    {
        public int Id { get; set; }
        public string Actor { get; set; }
        public int Series { get; set; }
        public int Age { get; set; }
        public string Debut { get; set; }
        public Image Picture { get; set; }

        /// <summary>
        /// Creates a new Doctor
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="actor">actor's name</param>
        /// <param name="series">series</param>
        /// <param name="age">age of the actor when they started</param>
        /// <param name="debut">storyid of the first episode this doctor played in</param>
        /// <param name="picture">picture of the doctor</param>
        public Doctor(int id, string actor, int series, int age, string debut, Image picture)
        {
            Id = id;
            Actor = actor;
            Series = series;
            Age = age;
            Debut = debut;
            Picture = picture;
        }
    }
}
