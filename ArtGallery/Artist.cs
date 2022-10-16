using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery
{
    public class Artist
    {
        public string firstName;
        public string lastName;
        public string nationality;
        public string birthday;
        public int age;
        public bool male;
        public string typeOfArt;

        public Artist(string afirstName, string alastName, string anationality, string abirthday, int aage, bool amale, string atypeOfArt)
        {
            this.firstName = afirstName;
            this.lastName = alastName;
            this.nationality = anationality;
            this.birthday = abirthday;
            this.age = aage;
            this.male = amale;
            this.typeOfArt = atypeOfArt;
        }

      

    }

}
