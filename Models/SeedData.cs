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
                context.Anime.AddRange(
                    new Anime {
                        Show = "Jujustu Kaisen",
                        Character = "Yuji Itadori",
                        Characters = new List<Character> {
                            new Character {Strength = 10, Speed = 10, SpecialAbility = "Black Flash"}
                        }
                    },
                    new Anime {
                        Show = "Jujustu Kaisen",
                        Character = "Megumi Fushiguro",
                        Characters = new List<Character> {
                            new Character {Strength = 4, Speed = 5, SpecialAbility = "Ten Shadows"}
                        }
                    },
                    new Anime {
                        Show = "Jujutsu Kaisen",
                        Character = "Nobara Kugisaki",
                        Characters = new List<Character> {
                            new Character {Strength = 2, Speed = 2, SpecialAbility = "Resonance"}
                        }
                    },
                    new Anime {
                        Show = "Jujutsu Kaisen",
                        Character = "Aoi Todo",
                        Characters = new List<Character> {
                            new Character {Strength = 10, Speed = 9, SpecialAbility = "Boogie Woogie"}
                        }
                    },
                    new Anime {
                        Show = "Jujutsu Kaisen",
                        Character = "Kento Nanami",
                        Characters = new List<Character> {
                            new Character {Strength = 7, Speed = 8, SpecialAbility = "Ratio"}
                        }
                    },
                    new Anime {
                        Show = "Jujutsu Kaisen",
                        Character = "Ryomen Sukuna",
                        Characters = new List<Character> {
                            new Character {Strength = 10, Speed = 10, SpecialAbility = "Molevanant Shrine"}
                        }
                    }
                );
                context.SaveChanges();
             }
        }
    }
}