using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AnimeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AnimeContext>>()))
            {
                if (context == null || context.Anime == null)
                {
                    throw new ArgumentNullException("Null RazorPagesAnimeContext");
                }

                if (context.Anime.Any())
                {
                    return;   
                }
                var Anime = new Anime
                {
                    Show = "Jujutsu Kaisen",
                    Characters = new List<Character>
                    {
                        new Character {CharacterName = "Yuji Itadori", Strength = 10, Speed = 10, SpecialAbility = "Black Flash"},
                        new Character {CharacterName = "Megumi Fushiguro", Strength = 4, Speed = 5, SpecialAbility = "Ten Shadows"},
                        new Character {CharacterName = "Nobara Kugisaki", Strength = 2, Speed = 2, SpecialAbility = "Resonance"},
                        new Character {CharacterName = "Aoi Todo", Strength = 10, Speed = 9, SpecialAbility = "Boogie Woogie"},
                        new Character {CharacterName = "Kento Nanami", Strength = 7, Speed = 8, SpecialAbility = "Ratio"},
                        new Character {CharacterName = "Ryomen Sukuna", Strength = 10, Speed = 10, SpecialAbility = "Molevanant Shrine"},
                        new Character {CharacterName = "Maki Zenin", Strength = 8, Speed = 9, SpecialAbility = "Cursed Weapons"},
                        new Character {CharacterName = "Toge Inumaki", Strength = 2, Speed = 3, SpecialAbility = "Cursed Speech"},
                        new Character {CharacterName = "Panda", Strength = 8, Speed = 5, SpecialAbility = "Cursed Object"},
                        new Character {CharacterName = "Yuta Okkotsu", Strength = 7, Speed = 9, SpecialAbility = "Copy"},
                        new Character {CharacterName = "Noritoshi Kamo", Strength = 6, Speed = 6, SpecialAbility = "Blood Manipulation"},
                        new Character {CharacterName = "Mahito", Strength = 9, Speed = 9, SpecialAbility = "Soul Manipulation"},
                        new Character {CharacterName = "Hanami", Strength = 10, Speed = 8, SpecialAbility = "Plant Creation"},
                        new Character {CharacterName = "Dagon", Strength = 8, Speed = 8, SpecialAbility = "Horizon of the Captivating Skandha"},
                        new Character {CharacterName = "Choso", Strength = 9, Speed = 9, SpecialAbility = "Blood Manipulation"},
                        new Character {CharacterName = "Kenjaku", Strength = 8, Speed = 9, SpecialAbility = "Uzumaki"},
                        new Character {CharacterName = "Toji Fushiguro", Strength = 10, Speed = 10, SpecialAbility = "None"},
                        new Character {CharacterName = "Takuma Ino", Strength = 7, Speed = 5, SpecialAbility = "Auspicious Beasts Summon"},
                        new Character {CharacterName = "Mei Mei", Strength = 8, Speed = 9, SpecialAbility = "Bird Strike"},
                        new Character {CharacterName = "Yuki Tsukumo", Strength = 9, Speed = 9, SpecialAbility = "Garuda"},
                        new Character {CharacterName = "Satoru Gojo", Strength = 10, Speed = 10, SpecialAbility = "Unlimited Void"},
                        new Character {CharacterName = "Mai Zenin", Strength = 6, Speed = 7, SpecialAbility = "Construction"},
                        new Character {CharacterName = "Jogo", Strength = 9, Speed = 7, SpecialAbility = "Disaster Flames"},
                        new Character {CharacterName = "Eso", Strength = 9, Speed = 9, SpecialAbility = "Decay"},
                        new Character {CharacterName = "Kenchizu", Strength = 9, Speed = 9, SpecialAbility = "Rot Technique"},
                    }
                };

                context.Anime.Add(Anime);
                context.SaveChanges();
             }
        }
    }
}