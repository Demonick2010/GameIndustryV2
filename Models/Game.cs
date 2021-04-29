using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameIndustryV2.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Image { get; set; }
        public string ShortName
        {
            get 
            {
                if (string.IsNullOrWhiteSpace(Name))
                    return null;

                if (Name.Length > 60)
                    return Name.Substring(0, 57) + "...";
                else
                    return Name;
            }
        }

    }
}
