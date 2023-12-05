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
                    }
                };

                context.Anime.Add(Anime);
                context.SaveChanges();
             }
        }
    }
}