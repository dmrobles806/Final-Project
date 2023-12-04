using System;
using System.Collections.Generic;

namespace Final_Project.Models
{
    public class Anime
    {
        public int AnimeID {get; set;} // Primary Key

        public string Show {get; set;} = string.Empty;

        public string Character {get; set;} = string.Empty;

        public List<Character> Characters {get; set;} = default!;

    }
}