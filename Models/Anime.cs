using System;
using System.Collections.Generic;

namespace Final_Project
{
    public class Anime
    {
        public int AnimeID {get; set;} // Primary Key

        public string Character {get; set;} = string.Empty;

        public List<Character> Characters {get; set;} = default!;

    }
}