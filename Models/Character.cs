using System;

namespace Final_Project.Models
{
    public class Character
    {
        public int CharacterID {get; set;} // Primary Key
        public string CharacterName {get; set;} = string.Empty;
        public int Strength {get; set;}
        public int Speed {get; set;}
        public string SpecialAbility {get; set;} = string.Empty;


        public Anime Anime {get; set;} = default!;
    }
}