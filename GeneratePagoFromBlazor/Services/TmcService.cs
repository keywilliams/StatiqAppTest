using GeneratePagoFromBlazor.Models;

namespace GeneratePagoFromBlazor.Services
{
    public class TmcService
    {
        public TmcService()
        {

        }

        public List<SiteModel> GetSiteConfigurations()
        {
            return new List<SiteModel>
            {
                //new SiteModel("https://github.com/keywilliams/StatiqAppTest/raw/master/input.zip", "Teste"),
                new SiteModel("https://github.com/keywilliams/StatiqAppTest/raw/master/input_tmc.zip", "TMC")
            };
        }

        public List<SiteColor> GetSiteColors()
        {
            return new List<SiteColor>
            {
                new SiteColor("MainColor", "green"),
                new SiteColor("BackgroundColor", "yellow")
            };
        }

        public List<Language> GetSiteLanguages()
        {
            return new List<Language>
            {
                new Language("pt", "PT"),
                new Language("en", "EN"),
                new Language("es", "ES")
            };
        }

        public LanguageModel GetTmcIndex(List<Language> languages)
        {
            var index = new LanguageModel
            {
                IndexCollection = new Dictionary<string, IndexViewModel>
                {
                    {"pt", new IndexViewModel
                    {
                        Movies = new List<MovieDetailModel>
                        {
                             new MovieDetailModel
                             {
                                 Name = "Titanic",
                                 Description = "O RMS Titanic foi um navio de passageiros britânico operado pela White Star Line e construído pelos estaleiros da Harland and Wolff, em Belfast.",
                                 Image = "Titanic.jpg",
                                 BannerImage = "Titanic-banner.jpg",
                                 Cast = "Teste",
                                 Copyright = "Teste",
                                 Director = "Teste",
                                 Genre = "Teste",
                                 Released = "Teste",
                                 Studio = "Teste",
                                 Year = 1998 ,
                                 ContentType = Models.ContentType.Movie,
                                 ImdbRating = 8.5M,
                                 SiteLanguages = languages,
                                 Title = "Titanic PT",
                                 MetaDescription = "Página Titanic PT",
                                 OgTitle = "Página Titanic PT",
                                 Robots = "Titanic PT"
                             },
                             new MovieDetailModel
                             {
                                 Name = "Matrix",
                                 Description = "Um jovem programador é atormentado por estranhos pesadelos nos quais sempre está conectado por cabos a um imenso sistema de computadores do futuro. À medida que o sonho se repete, ele começa a levantar dúvidas sobre a realidade.",
                                 Image = "Matrix.jpg",
                                 BannerImage = "Matrix-banner.jpg",
                                 Cast = "Teste",
                                 Copyright = "Teste",
                                 Director = "Teste",
                                 Genre = "Teste",
                                 Released = "Teste",
                                 Studio = "Teste",
                                 Year = 1999,
                                 ContentType = Models.ContentType.Movie,
                                 ImdbRating = 8.5M,
                                 SiteLanguages = languages,
                                 Title = "Matrix PT",
                                 MetaDescription = "Página Matrix PT",
                                 OgTitle = "Página Matrix PT",
                                 Robots = "Matrix PT"
                             },
                             new MovieDetailModel
                             {
                                 Name = "Avatar",
                                 Description = "No exuberante mundo alienígena de Pandora vivem os Na'vi, seres que parecem ser primitivos, mas são altamente evoluídos. Como o ambiente do planeta é tóxico, foram criados os avatares, corpos biológicos controlados pela mente humana que se movimentam livremente em Pandora.",
                                 Image = "Avatar.jpg",
                                 BannerImage = "Avatar-banner.jpg",
                                 Cast = "Teste",
                                 Copyright = "Teste",
                                 Director = "Teste",
                                 Genre = "Teste",
                                 Released = "Teste",
                                 Studio = "Teste",
                                 Year = 2009,
                                 ContentType = Models.ContentType.Movie,
                                 ImdbRating = 8.5M,
                                 SiteLanguages = languages,
                                 Title = "Avatar PT",
                                 MetaDescription = "Página Avatar PT",
                                 OgTitle = "Página Avatar PT",
                                 Robots = "Avatar PT"
                             },
                             new MovieDetailModel
                             {
                                 Name = "Hulk",
                                 Description = "Bruce Banner é um cientista e trabalha ao lado de sua grande paixão, a bela Betty Ross, em um projeto que envolve a reconstituição de tecidos com a utilização da radiação gama.",
                                 Image = "Hulk.jpg",
                                 BannerImage = "Hulk-banner.jpg",
                                 Cast = "Teste",
                                 Copyright = "Teste",
                                 Director = "Teste",
                                 Genre = "Teste",
                                 Released = "Teste",
                                 Studio = "Teste",
                                 Year = 2003,
                                 ContentType = Models.ContentType.Movie,
                                 ImdbRating = 8.5M,
                                 SiteLanguages = languages,
                                 Title = "Hulk PT",
                                 MetaDescription = "Página Hulk PT",
                                 OgTitle = "Página Hulk PT",
                                 Robots = "Hulk PT"
                             }
                        },
                        Audios = new List<AudioDetailModel>
                        {
                            new AudioDetailModel
                            {
                                Name = "Adele 21",
                                Description = "Adele Laurie Blue Adkins MBE (Londres, 5 de maio de 1988) é uma cantora, compositora e multi-instrumentista britânica. Ela é uma das artistas recordistas de vendas no mundo, com mais de 120 milhões de discos vendidos.",
                                Image = "Adele21.jpg",
                                BannerImage = "Adele21-banner.jpg",
                                Year = 2022 ,
                                ContentType = Models.ContentType.Audio,
                                ImdbRating = 8.5M,
                                TrackList = new List<Track>
                                {
                                    new Track { Id = 1, Description = "Rolling in the Deep", Duration = "3:48" },
                                    new Track { Id = 2, Description = "Rumour Has It", Duration = "3:43" },
                                    new Track { Id = 3, Description = "Turning Tables", Duration = "4:10" },
                                    new Track { Id = 4, Description = "Don’t You Remember", Duration = "4:03" },
                                    new Track { Id = 5, Description = "Set Fire to the Rain", Duration = "4:02" },
                                    new Track { Id = 6, Description = "He Won’t Go", Duration = "4:38" },
                                    new Track { Id = 7, Description = "Take It All", Duration = "3:48" },
                                    new Track { Id = 8, Description = "I'll Be Waiting", Duration = "4:02" },
                                    new Track { Id = 9, Description = "One and Only", Duration = "5:48" },
                                    new Track { Id = 10, Description = "Love Song", Duration = "5:16" },
                                    new Track { Id = 11, Description = "Someone Like You", Duration = "4:45" },
                                },
                                 SiteLanguages = languages,
                                 Title = "Adele 21 PT",
                                 MetaDescription = "Página Adele 21 PT",
                                 OgTitle = "Página Adele 21 PT",
                                 Robots = "Adele 21 PT"
                            },
                            new AudioDetailModel
                            {
                                Name = "Linkin Park",
                                Description = "Linkin Park é uma banda de rock dos Estados Unidos formada em Agoura Hills, Califórnia. A formação atual da banda inclui o vocalista e multi-instrumentista Mike Shinoda, o guitarrista Brad Delson, o baixista Dave Farrell, o DJ Joe Hahn e o baterista Rob Bourdon, todos membros fundadores.",
                                Image = "LinkinPark.jpg",
                                BannerImage = "LinkinPark-banner.jpg",
                                Year = 2022 ,
                                ContentType = Models.ContentType.Audio,
                                ImdbRating = 8.5M,
                                TrackList = new List<Track>
                                {
                                    new Track { Id = 1, Description = "Somewhere I Belong", Duration = "3:48" },
                                    new Track { Id = 2, Description = "Lying from You (Live in Texas)", Duration = "3:43" },
                                    new Track { Id = 3, Description = "Papercut", Duration = "4:10" },
                                    new Track { Id = 4, Description = "Points of Authority", Duration = "4:03" },
                                    new Track { Id = 5, Description = "Runaway (live)", Duration = "4:02" },
                                    new Track { Id = 6, Description = "Faint", Duration = "4:38" },
                                    new Track { Id = 7, Description = "From the Inside (Live in Texas)", Duration = "3:48" },
                                    new Track { Id = 8, Description = "P5hng Me A*wy (Live in Texas)", Duration = "4:02" },
                                    new Track { Id = 9, Description = "Numb", Duration = "5:48" },
                                    new Track { Id = 10, Description = "Crawling", Duration = "5:16" },
                                    new Track { Id = 11, Description = "In The End", Duration = "4:45" },
                                    new Track { Id = 12, Description = "One Step Closer", Duration = "4:45" }
                                },
                                 SiteLanguages = languages,
                                 Title = "Linkin Park PT",
                                 MetaDescription = "Página Linkin Park PT",
                                 OgTitle = "Página Linkin Park PT",
                                 Robots = "Linkin Park PT"
                            }
                        },
                        Tvs = new List<TvDetailModel>
                        {
                            new TvDetailModel
                            {
                                Name = "All American",
                                Season = 1,
                                Description = "All American é uma série de drama de televisão americana, criada por April Blair, que estreou no canal The CW em 10 de outubro de 2018. A série é inspirada na vida do jogador de futebol profissional Spencer Paysinger.",
                                ImdbRating= 9.2M,
                                Year = 2019,
                                Image = "AllAmericanS1.jpg",
                                BannerImage = "AllAmericanS1-banner.jpg",
                                Cast = "Teste",
                                Copyright = "Teste",
                                Director = "Teste",
                                Genre = "Teste",
                                Released = "Teste",
                                Studio = "Teste",
                                ContentType = Models.ContentType.TV,
                                Episodes = new List<Episode>
                                {
                                    new Episode { Id = 1, Description = "Pilot", Duration = "1:05" },
                                    new Episode { Id = 2, Description = "99 Problems", Duration = "1:02" },
                                    new Episode { Id = 3, Description = "i", Duration = "0:55" },
                                    new Episode { Id = 4, Description = "Lose Yourself", Duration = "0:59" },
                                    new Episode { Id = 5, Description = "All We Got", Duration = "1:00" },
                                },
                                 SiteLanguages = languages,
                                 Title = "All American PT",
                                 MetaDescription = "Página All American PT",
                                 OgTitle = "Página All American PT",
                                 Robots = "All American PT"
                            },
                            new TvDetailModel
                            {
                                Name = "The Big Bang Theory",
                                Season = 1,
                                Description = "The Big Bang Theory é uma série de televisão norte-americana de comédia de situação que estreou na CBS em 24 de setembro de 2007 e terminou em 16 de maio de 2019, tendo total de 279 episódios em doze temporadas. Criada por Chuck Lorre e Bill Prady, a série conta com cinco personagens que vivem em Pasadena.",
                                ImdbRating= 8.2M,
                                Year = 2007,
                                Image = "TheBigBangTheoryS1.jpg",
                                BannerImage = "TheBigBangTheoryS1-banner.jpg",
                                Cast = "Teste",
                                Copyright = "Teste",
                                Director = "Teste",
                                Genre = "Teste",
                                Released = "Teste",
                                Studio = "Teste",
                                ContentType = Models.ContentType.TV,
                                Episodes = new List<Episode>
                                {
                                    new Episode { Id = 0, Description = "Unaired Pilot", Duration = "1:05" },
                                    new Episode { Id = 1, Description = "Pilot", Duration = "1:05" },
                                    new Episode { Id = 2, Description = "The Big Bran Hypothesis", Duration = "1:02" },
                                    new Episode { Id = 3, Description = "The Fuzzy Boots Corollary", Duration = "0:55" },
                                    new Episode { Id = 4, Description = "The Luminous Fish Effect", Duration = "0:59" },
                                    new Episode { Id = 5, Description = "The Hamburger Postulate", Duration = "1:00" },
                                },
                                 SiteLanguages = languages,
                                 Title = "The Big Bang Theory PT",
                                 MetaDescription = "Página The Big Bang Theory PT",
                                 OgTitle = "Página The Big Bang Theory PT",
                                 Robots = "The Big Bang Theory PT"
                            },
                            new TvDetailModel
                            {
                                Name = "How to Get Away with Murder",
                                Season = 1,
                                Description = "How to Get Away with Murder (Br: Como Defender Um Assassino; Pt: Como Defender Um Assassino) é uma série de televisão de suspense norte-americana que estreou na ABC em 25 de setembro de 2014 e foi concluída em 14 de maio de 2020.",
                                ImdbRating= 8.2M,
                                Year = 2014,
                                Image = "htgawmS1.jpg",
                                BannerImage = "htgawmS1-banner.jpg",
                                Cast = "Teste",
                                Copyright = "Teste",
                                Director = "Teste",
                                Genre = "Teste",
                                Released = "Teste",
                                Studio = "Teste",
                                ContentType = Models.ContentType.TV,
                                Episodes = new List<Episode>
                                {
                                    new Episode { Id = 1, Description = "Pilot", Duration = "1:05" },
                                    new Episode { Id = 2, Description = "It's All Her Fault", Duration = "1:02" },
                                    new Episode { Id = 3, Description = "Smile, or Go to Jail", Duration = "0:55" },
                                    new Episode { Id = 4, Description = "Let's Get to Scooping", Duration = "0:59" },
                                    new Episode { Id = 5, Description = "We're Not Friends", Duration = "1:00" },
                                },
                                 SiteLanguages = languages,
                                 Title = "How to Get Away with Murder PT",
                                 MetaDescription = "Página How to Get Away with Murder PT",
                                 OgTitle = "Página How to Get Away with Murder PT",
                                 Robots = "How to Get Away with Murder PT"
                            },
                            new TvDetailModel
                            {
                                Name = "The Simpsons",
                                Season = 1,
                                Description = "The Simpsons (bra/prt: Os Simpsons) é uma série de animação e sitcom norte-americana criada por Matt Groening para a Fox Broadcasting Company. A série é uma paródia satírica do estilo de vida da classe média dos Estados Unidos (como cultura, sociedade e televisão) e aspectos da condição humana, através da família protagonista, que consiste de Homer Jay Simpson, Marjorie (Marge) Bouvier Simpson, Bartholomew (Bart) Simpson, Elisabeth (Lisa) Marie Simpson e Margareth (Maggie) Simpson, cuja vida se passa na fictícia cidade de Springfield.",
                                ImdbRating= 8.7M,
                                Year = 1989,
                                Image = "TheSimpsonsS1.jpg",
                                BannerImage = "TheSimpsonsS1-banner.jpg",
                                Cast = "Teste",
                                Copyright = "Teste",
                                Director = "Teste",
                                Genre = "Teste",
                                Released = "Teste",
                                Studio = "Teste",
                                ContentType = Models.ContentType.TV,
                                Episodes = new List<Episode>
                                {
                                    new Episode { Id = 1, Description = "Simpsons Roasting on an Open Fire", Duration = "1:05" },
                                    new Episode { Id = 2, Description = "Bart the Genius", Duration = "1:02" },
                                    new Episode { Id = 3, Description = "Homer's Odyssey", Duration = "0:55" },
                                    new Episode { Id = 4, Description = "There's No Disgrace Like Home", Duration = "0:59" },
                                    new Episode { Id = 5, Description = "Bart the General", Duration = "1:00" },
                                },
                                 SiteLanguages = languages,
                                 Title = "The Simpsons PT",
                                 MetaDescription = "Página Simpsons PT",
                                 OgTitle = "Página The Simpsons PT",
                                 Robots = "The Simpsons PT"
                            }
                        },
                        Categories = new List<Item>
                        {
                            new Item(1, "Filme"),
                            new Item(2, "Música"),
                            new Item(3, "Série")
                        },
                        Dates = new List<Item>
                        {
                            new Item(1, "01/01/2001"),
                            new Item(2, "02/02/2002"),
                            new Item(3, "03/03/2003")
                        },
                        FlightNumber = new List<Item>
                        {
                            new Item(1, "12345"),
                            new Item(2, "54321"),
                            new Item(3, "99887")
                        },
                        From = new List <Item>
                        {
                            new Item(1, "Lisboa"),
                            new Item(2, "Brasil"),
                            new Item(3, "Espanha")
                        },
                        Genres = new List<Item>
                        {
                            new Item(1, "Drama"),
                            new Item(2, "Ficção"),
                            new Item(3, "Terror")
                        },
                        Languages = new List<Item>
                        {
                            new Item(1, "PT"),
                            new Item(2, "EN"),
                            new Item(3, "ES")
                        },
                        SortBy = new List<Item>
                        {
                            new Item(1, "Asc"),
                            new Item(3, "Desc")
                        },
                        Subtitles = new List<Item>
                        {
                            new Item(1, "PT"),
                            new Item(2, "EN"),
                            new Item(3, "ES")
                        },
                        To = new List<Item>
                        {
                            new Item(1, "Lisboa"),
                            new Item(2, "Brasil"),
                            new Item(3, "Espanha")
                        },
                        Modal = new ModalModel
                        {
                            Dates = new List<Item>
                            {
                                new Item(1, "01/01/2001"),
                                new Item(2, "02/02/2002"),
                                new Item(3, "03/03/2003")
                            },
                            FlightNumber = new List<Item>
                            {
                                new Item(1, "12345"),
                                new Item(2, "54321"),
                                new Item(3, "99887")
                            },
                            From = new List <Item>
                            {
                                new Item(1, "Lisboa"),
                                new Item(2, "Brasil"),
                                new Item(3, "Espanha")
                            },
                            To = new List<Item>
                            {
                                new Item(1, "Lisboa"),
                                new Item(2, "Brasil"),
                                new Item(3, "Espanha")
                            }
                        },
                        SiteLanguages = languages,
                        Title = "Index PT",
                        Name= "Index",
                        MetaDescription = "Página Index PT",
                        OgTitle = "Página Index PT",
                        Robots = "Index PT"
                    }},
                    {"en", new IndexViewModel
                    {
                        Movies = new List<MovieDetailModel>
                        {
                             new MovieDetailModel
                             {
                                 Name = "Titanic",
                                 Description = "RMS Titanic was the largest ship afloat at the time she entered service and the second of three Olympic-class ocean liners operated by the White Star Line. She was built by the Harland and Wolff shipyard in Belfast.",
                                 Image = "Titanic.jpg",
                                 BannerImage = "Titanic-banner.jpg",
                                 Cast = "Teste",
                                 Copyright = "Teste",
                                 Director = "Teste",
                                 Genre = "Teste",
                                 Released = "Teste",
                                 Studio = "Teste",
                                 Year = 1998,
                                 ContentType = Models.ContentType.Movie,
                                 ImdbRating = 8.5M,
                                 SiteLanguages = languages,
                                 Title = "Titanic EN",
                                 MetaDescription = "Titanic Page EN",
                                 OgTitle = "Página Titanic EN",
                                 Robots = "Titanic EN"
                             },
                             new MovieDetailModel
                             {
                                 Name = "Matrix",
                                 Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis.[a] It is the first installment in The Matrix film series, starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, it depicts a dystopian future in which humanity is unknowingly trapped inside the Matrix, a simulated reality that intelligent machines have created to distract humans while using their bodies as an energy source.",
                                 Image = "Matrix.jpg",
                                 BannerImage = "Matrix-banner.jpg",
                                 Cast = "Teste",
                                 Copyright = "Teste",
                                 Director = "Teste",
                                 Genre = "Teste",
                                 Released = "Teste",
                                 Studio = "Teste",
                                 Year = 1999,
                                 ContentType = Models.ContentType.Movie,
                                 ImdbRating = 8.5M,
                                 SiteLanguages = languages,
                                 Title = "The Matrix EN",
                                 MetaDescription = "The Matrix Page EN",
                                 OgTitle = "The Matrix Page EN",
                                 Robots = "The Matrix EN"
                             },
                             new MovieDetailModel
                             {
                                 Name = "Avatar",
                                 Description = "Avatar (also marketed as James Cameron's Avatar) is a 2009 American epic science fiction film directed, written, produced, and co-edited by James Cameron and starring Sam Worthington, Zoe Saldana, Stephen Lang, Michelle Rodriguez and Sigourney Weaver. It is set in the mid-22nd century when humans are colonizing Pandora, a lush habitable moon of a gas giant in the Alpha Centauri star system, in order to mine the valuable mineral unobtanium.",
                                 Image = "Avatar.jpg",
                                 BannerImage = "Avatar-banner.jpg",
                                 Cast = "Teste",
                                 Copyright = "Teste",
                                 Director = "Teste",
                                 Genre = "Teste",
                                 Released = "Teste",
                                 Studio = "Teste",
                                 Year = 2009,
                                 ContentType = Models.ContentType.Movie,
                                 ImdbRating = 8.5M,
                                 SiteLanguages = languages,
                                 Title = "Avatar EN",
                                 MetaDescription = "Avatar Page EN",
                                 OgTitle = "Avatar Page EN",
                                 Robots = "Avatar EN"
                             },
                             new MovieDetailModel
                             {
                                 Name = "Hulk",
                                 Description = "Hulk (also known as The Hulk) is a 2003 American superhero film based on the Marvel Comics character of the same name, created by Stan Lee and Jack Kirby. Directed by Ang Lee and written by James Schamus, Michael France, and John Turman from a story by Schamus, it stars Eric Bana as Bruce Banner/Hulk, alongside Jennifer Connelly, Sam Elliott, Josh Lucas, and Nick Nolte.",
                                 Image = "Hulk.jpg",
                                 BannerImage = "Hulk-banner.jpg",
                                 Cast = "Teste",
                                 Copyright = "Teste",
                                 Director = "Teste",
                                 Genre = "Teste",
                                 Released = "Teste",
                                 Studio = "Teste",
                                 Year = 2003,
                                 ContentType = Models.ContentType.Movie,
                                 ImdbRating = 8.5M,
                                 SiteLanguages = languages,
                                 Title = "The Hulk EN",
                                 MetaDescription = "The Hulk Page EN",
                                 OgTitle = "The Hulk Page EN",
                                 Robots = "The Hulk Page EN"
                             }
                        },
                        Audios = new List<AudioDetailModel>
                        {
                            new AudioDetailModel
                            {
                                Name = "Adele 21",
                                Description = "Adele Laurie Blue Adkins MBE (born 5 May 1988) is an English singer and songwriter. After graduating in arts from the BRIT School in 2006, Adele signed a record deal with XL Recordings.",
                                Image = "Adele21.jpg",
                                BannerImage = "Adele21-banner.jpg",
                                Year = 2022 ,
                                ContentType = Models.ContentType.Audio,
                                ImdbRating = 8.5M,
                                TrackList = new List<Track>
                                {
                                    new Track { Id = 1, Description = "Rolling in the Deep", Duration = "3:48" },
                                    new Track { Id = 2, Description = "Rumour Has It", Duration = "3:43" },
                                    new Track { Id = 3, Description = "Turning Tables", Duration = "4:10" },
                                    new Track { Id = 4, Description = "Don’t You Remember", Duration = "4:03" },
                                    new Track { Id = 5, Description = "Set Fire to the Rain", Duration = "4:02" },
                                    new Track { Id = 6, Description = "He Won’t Go", Duration = "4:38" },
                                    new Track { Id = 7, Description = "Take It All", Duration = "3:48" },
                                    new Track { Id = 8, Description = "I'll Be Waiting", Duration = "4:02" },
                                    new Track { Id = 9, Description = "One and Only", Duration = "5:48" },
                                    new Track { Id = 10, Description = "Love Song", Duration = "5:16" },
                                    new Track { Id = 11, Description = "Someone Like You", Duration = "4:45" },
                                },
                                 SiteLanguages = languages,
                                 Title = "Adele 21 EN",
                                 MetaDescription = "Adele 21 Page EN",
                                 OgTitle = "Adele 21 Page EN",
                                 Robots = "Adele 21 EN"
                            },
                            new AudioDetailModel
                            {
                                Name = "Linkin Park",
                                Description = "Linkin Park is an American rock band from Agoura Hills, California. The band's current lineup comprises vocalist/rhythm guitarist/keyboardist Mike Shinoda, lead guitarist Brad Delson, bassist Dave Farrell, DJ/turntablist Joe Hahn and drummer Rob Bourdon, all of whom are founding members.",
                                Image = "LinkinPark.jpg",
                                BannerImage = "LinkinPark-banner.jpg",
                                Year = 2022 ,
                                ContentType = Models.ContentType.Audio,
                                ImdbRating = 8.5M,
                                TrackList = new List<Track>
                                {
                                    new Track { Id = 1, Description = "Somewhere I Belong", Duration = "3:48" },
                                    new Track { Id = 2, Description = "Lying from You (Live in Texas)", Duration = "3:43" },
                                    new Track { Id = 3, Description = "Papercut", Duration = "4:10" },
                                    new Track { Id = 4, Description = "Points of Authority", Duration = "4:03" },
                                    new Track { Id = 5, Description = "Runaway (live)", Duration = "4:02" },
                                    new Track { Id = 6, Description = "Faint", Duration = "4:38" },
                                    new Track { Id = 7, Description = "From the Inside (Live in Texas)", Duration = "3:48" },
                                    new Track { Id = 8, Description = "P5hng Me A*wy (Live in Texas)", Duration = "4:02" },
                                    new Track { Id = 9, Description = "Numb", Duration = "5:48" },
                                    new Track { Id = 10, Description = "Crawling", Duration = "5:16" },
                                    new Track { Id = 11, Description = "In The End", Duration = "4:45" },
                                    new Track { Id = 12, Description = "One Step Closer", Duration = "4:45" }
                                },
                                 SiteLanguages = languages,
                                 Title = "Linkin Park EN",
                                 MetaDescription = "Linkin Park Page EN",
                                 OgTitle = "Linkin Park Page EN",
                                 Robots = "Linkin Park EN"
                            }
                        },
                        Tvs = new List<TvDetailModel>
                        {
                            new TvDetailModel
                            {
                                Name = "All American",
                                Season = 1,
                                Description = "All American is an American sports drama television series, created by April Blair that premiered on The CW on October 10, 2018. The series is inspired by the life of professional American football player Spencer Paysinger, with Daniel Ezra in the lead role. In January 2020, The CW renewed the series for a third season which premiered on January 18, 2021.",
                                ImdbRating= 9.2M,
                                Year = 2019,
                                Image = "AllAmericanS1.jpg",
                                BannerImage = "AllAmericanS1-banner.jpg",
                                Cast = "Teste",
                                Copyright = "Teste",
                                Director = "Teste",
                                Genre = "Teste",
                                Released = "Teste",
                                Studio = "Teste",
                                ContentType = Models.ContentType.TV,
                                Episodes = new List<Episode>
                                {
                                    new Episode { Id = 1, Description = "Pilot", Duration = "1:05" },
                                    new Episode { Id = 2, Description = "99 Problems", Duration = "1:02" },
                                    new Episode { Id = 3, Description = "i", Duration = "0:55" },
                                    new Episode { Id = 4, Description = "Lose Yourself", Duration = "0:59" },
                                    new Episode { Id = 5, Description = "All We Got", Duration = "1:00" },
                                },
                                 SiteLanguages = languages,
                                 Title = "All American EN",
                                 MetaDescription = "All American Page EN",
                                 OgTitle = "All American Page EN",
                                 Robots = "All American EN"
                            },
                            new TvDetailModel
                            {
                                Name = "The Big Bang Theory",
                                Season = 1,
                                Description = "The Big Bang Theory is an American television sitcom created by Chuck Lorre and Bill Prady, both of whom served as executive producers on the series, along with Steven Molaro, all of whom also served as head writers. It premiered on CBS on September 24, 2007, and concluded on May 16, 2019, having broadcast 279 episodes over 12 seasons.",
                                ImdbRating= 8.2M,
                                Year = 2007,
                                Image = "TheBigBangTheoryS1.jpg",
                                BannerImage = "TheBigBangTheoryS1-banner.jpg",
                                Cast = "Teste",
                                Copyright = "Teste",
                                Director = "Teste",
                                Genre = "Teste",
                                Released = "Teste",
                                Studio = "Teste",
                                ContentType = Models.ContentType.TV,
                                Episodes = new List<Episode>
                                {
                                    new Episode { Id = 0, Description = "Unaired Pilot", Duration = "1:05" },
                                    new Episode { Id = 1, Description = "Pilot", Duration = "1:05" },
                                    new Episode { Id = 2, Description = "The Big Bran Hypothesis", Duration = "1:02" },
                                    new Episode { Id = 3, Description = "The Fuzzy Boots Corollary", Duration = "0:55" },
                                    new Episode { Id = 4, Description = "The Luminous Fish Effect", Duration = "0:59" },
                                    new Episode { Id = 5, Description = "The Hamburger Postulate", Duration = "1:00" },
                                },
                                 SiteLanguages = languages,
                                 Title = "The Big Bang Theory EN",
                                 MetaDescription = "The Big Bang Theory Page EN",
                                 OgTitle = "The Big Bang Theory Page EN",
                                 Robots = "The Big Bang Theory EN"
                            },
                            new TvDetailModel
                            {
                                Name = "How to Get Away with Murder",
                                Season = 1,
                                Description = "How to Get Away with Murder is an American legal thriller television series that premiered on ABC on September 25, 2014, and concluded on May 14, 2020. The series was created by Peter Nowalk, and produced by Shonda Rhimes and ABC Studios. ",
                                ImdbRating= 8.2M,
                                Year = 2014,
                                Image = "htgawmS1.jpg",
                                BannerImage = "htgawmS1-banner.jpg",
                                Cast = "Teste",
                                Copyright = "Teste",
                                Director = "Teste",
                                Genre = "Teste",
                                Released = "Teste",
                                Studio = "Teste",
                                ContentType = Models.ContentType.TV,
                                Episodes = new List<Episode>
                                {
                                    new Episode { Id = 1, Description = "Pilot", Duration = "1:05" },
                                    new Episode { Id = 2, Description = "It's All Her Fault", Duration = "1:02" },
                                    new Episode { Id = 3, Description = "Smile, or Go to Jail", Duration = "0:55" },
                                    new Episode { Id = 4, Description = "Let's Get to Scooping", Duration = "0:59" },
                                    new Episode { Id = 5, Description = "We're Not Friends", Duration = "1:00" },
                                },
                                 SiteLanguages = languages,
                                 Title = "How to Get Away with Murder EN",
                                 MetaDescription = "How to Get Away with Murder Page EN",
                                 OgTitle = "How to Get Away with Murder Page EN",
                                 Robots = "How to Get Away with Murder EN"
                            },
                            new TvDetailModel
                            {
                                Name = "The Simpsons",
                                Season = 1,
                                Description = "The Simpsons is an American animated sitcom created by Matt Groening for the Fox Broadcasting Company. The series is a satirical depiction of American life, epitomized by the Simpson family, which consists of Homer, Marge, Bart, Lisa, and Maggie. The show is set in the fictional town of Springfield and parodies American culture and society, television, and the human condition.",
                                ImdbRating= 8.7M,
                                Year = 1989,
                                Image = "TheSimpsonsS1.jpg",
                                BannerImage = "TheSimpsonsS1-banner.jpg",
                                Cast = "Teste",
                                Copyright = "Teste",
                                Director = "Teste",
                                Genre = "Teste",
                                Released = "Teste",
                                Studio = "Teste",
                                ContentType = Models.ContentType.TV,
                                Episodes = new List<Episode>
                                {
                                    new Episode { Id = 1, Description = "Simpsons Roasting on an Open Fire", Duration = "1:05" },
                                    new Episode { Id = 2, Description = "Bart the Genius", Duration = "1:02" },
                                    new Episode { Id = 3, Description = "Homer's Odyssey", Duration = "0:55" },
                                    new Episode { Id = 4, Description = "There's No Disgrace Like Home", Duration = "0:59" },
                                    new Episode { Id = 5, Description = "Bart the General", Duration = "1:00" },
                                },
                                 SiteLanguages = languages,
                                 Title = "The Simpsons EN",
                                 MetaDescription = "The Simpsons Page EN",
                                 OgTitle = "The Simpsons Page EN",
                                 Robots = "The Simpsons EN"
                            }
                        },
                        Categories = new List<Item>
                        {
                            new Item(1, "Movie"),
                            new Item(2, "Song"),
                            new Item(3, "Series")
                        },
                        Dates = new List<Item>
                        {
                            new Item(1, "01/01/2001"),
                            new Item(2, "02/02/2002"),
                            new Item(3, "03/03/2003")
                        },
                        FlightNumber = new List<Item>
                        {
                            new Item(1, "12345"),
                            new Item(2, "54321"),
                            new Item(3, "99887")
                        },
                        From = new List < Item >
                        {
                            new Item(1, "Lisbon"),
                            new Item(2, "Brazil"),
                            new Item(3, "Spain")
                        },
                        Genres = new List<Item>
                        {
                            new Item(1, "Drama"),
                            new Item(2, "Fiction"),
                            new Item(3, "Horror")
                        },
                        Languages = new List<Item>
                        {
                            new Item(1, "PT"),
                            new Item(2, "EN"),
                            new Item(3, "ES")
                        },
                        SortBy = new List<Item>
                        {
                            new Item(1, "Asc"),
                            new Item(3, "Desc")
                        },
                        Subtitles = new List<Item>
                        {
                            new Item(1, "PT"),
                            new Item(2, "EN"),
                            new Item(3, "ES")
                        },
                        To = new List<Item>
                        {
                            new Item(1, "Lisbon"),
                            new Item(2, "Brazil"),
                            new Item(3, "Spain")
                        },
                        Modal = new ModalModel
                        {
                            Dates = new List<Item>
                            {
                                new Item(1, "01/01/2001"),
                                new Item(2, "02/02/2002"),
                                new Item(3, "03/03/2003")
                            },
                            FlightNumber = new List<Item>
                            {
                                new Item(1, "12345"),
                                new Item(2, "54321"),
                                new Item(3, "99887")
                            },
                            From = new List < Item >
                            {
                                new Item(1, "Lisbon"),
                                new Item(2, "Brazil"),
                                new Item(3, "Spain")
                            },
                            To = new List<Item>
                            {
                                new Item(1, "Lisbon"),
                                new Item(2, "Brazil"),
                                new Item(3, "Spain")
                            }
                        },
                        SiteLanguages = languages,
                        Title = "Index EN",
                        Name= "Index",
                        MetaDescription = "Index Page EN",
                        OgTitle = "Página Index EN",
                        Robots = "Index EN"
                    }},
                    {"es", new IndexViewModel
                    {
                        Movies = new List<MovieDetailModel>
                        {
                             new MovieDetailModel
                             {
                                 Name = "Titanic",
                                 Description = "Siendo construido entre 1909 y 1912 en los astilleros de Harland & Wolff de Belfast, el Titanic constituía el segundo buque de un trío de grandes transatlánticos (siendo el primero el RMS Olympic y el tercero el HMHS Britannic), propiedad de la compañía naviera White Star Line, conocidos como la clase Olympic.",
                                 Image = "Titanic.jpg",
                                 BannerImage = "Titanic-banner.jpg",
                                 Cast = "Teste",
                                 Copyright = "Teste",
                                 Director = "Teste",
                                 Genre = "Teste",
                                 Released = "Teste",
                                 Studio = "Teste",
                                 Year = 1998,
                                 ContentType = Models.ContentType.Movie,
                                 ImdbRating = 8.5M,
                                 SiteLanguages = languages,
                                 Title = "Titanic ES",
                                 OgTitle = "Página Titanic ES",
                                 Robots = "Titanic ES",
                                 MetaDescription = "Página Titanic ES"
                             },
                             new MovieDetailModel
                             {
                                 Name = "Matrix",
                                 Description = "The Matrix (conocida como Matrix en Hispanoamérica) es una película de acción y ciencia ficción de 1999 escrita y dirigida por las hermanas Wachowski y protagonizada por Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss y Hugo Weaving. Representa un futuro distópico en el que la humanidad está atrapada sin saberlo dentro de una realidad simulada llamada Matrix, que las máquinas inteligentes han creado para distraer a los humanos mientras usan sus cuerpos como fuente de energía en campos de cultivo.",
                                 Image = "Matrix.jpg",
                                 BannerImage = "Matrix-banner.jpg",
                                 Cast = "Teste",
                                 Copyright = "Teste",
                                 Director = "Teste",
                                 Genre = "Teste",
                                 Released = "Teste",
                                 Studio = "Teste",
                                 Year = 1999,
                                 ContentType = Models.ContentType.Movie,
                                 ImdbRating = 8.5M,
                                 SiteLanguages = languages,
                                 Title = "Matrix ES",
                                 OgTitle = "Página Matrix ES",
                                 Robots = "Matrix ES",
                                 MetaDescription = "Página Matrix ES"
                             },
                             new MovieDetailModel
                             {
                                 Name = "Avatar",
                                 Description = "Avatar (comercializada como Avatar de James Cameron) es una película épica de ciencia ficción militar, Animación y estadounidense de 2009,6​7​ escrita, producida y dirigida por James Cameron y protagonizada por Sam Worthington, Zoe Saldaña, Sigourney Weaver, Stephen Lang y Michelle Rodriguez.",
                                 Image = "Avatar.jpg",
                                 BannerImage = "Avatar-banner.jpg",
                                 Cast = "Teste",
                                 Copyright = "Teste",
                                 Director = "Teste",
                                 Genre = "Teste",
                                 Released = "Teste",
                                 Studio = "Teste",
                                 Year = 2009,
                                 ContentType = Models.ContentType.Movie,
                                 ImdbRating = 8.5M,
                                 SiteLanguages = languages,
                                 Title = "Avatar ES",
                                 OgTitle = "Página Avatar ES",
                                 Robots = "Avatar ES",
                                 MetaDescription = "Página Avatar ES"
                             },
                             new MovieDetailModel
                             {
                                 Name = "Hulk",
                                 Description = "Hulk es una película de 2003 basada en el personaje ficticio de Marvel Comics del mismo nombre.2​ Ang Lee dirigió el filme, que es protagonizado por Eric Bana como el Dr. Bruce Banner, así como Jennifer Connelly, Sam Elliott, Nick Nolte y Josh Lucas.",
                                 Image = "Hulk.jpg",
                                 BannerImage = "Hulk-banner.jpg",
                                 Cast = "Teste",
                                 Copyright = "Teste",
                                 Director = "Teste",
                                 Genre = "Teste",
                                 Released = "Teste",
                                 Studio = "Teste",
                                 Year = 2003,
                                 ContentType = Models.ContentType.Movie,
                                 ImdbRating = 8.5M,
                                 SiteLanguages = languages,
                                 Title = "Hulk ES",
                                 OgTitle = "Página Hulk ES",
                                 Robots = "Hulk ES",
                                 MetaDescription = "Página Hulk ES"
                             }
                        },
                        Audios = new List<AudioDetailModel>
                        {
                            new AudioDetailModel
                            {
                                Name = "Adele 21",
                                Description = "Adele Laurie Blue Adkins (Londres, 5 de mayo de 1988), conocida simplemente como Adele, es una cantautora y multinstrumentista británica.​ Es una de las artistas musicales con mayores ventas del mundo, con más de 120 millones de ventas entre discos y sencillos.",
                                Image = "Adele21.jpg",
                                BannerImage = "Adele21-banner.jpg",
                                Year = 2022 ,
                                ContentType = Models.ContentType.Audio,
                                ImdbRating = 8.5M,
                                TrackList = new List<Track>
                                {
                                    new Track { Id = 1, Description = "Rolling in the Deep", Duration = "3:48" },
                                    new Track { Id = 2, Description = "Rumour Has It", Duration = "3:43" },
                                    new Track { Id = 3, Description = "Turning Tables", Duration = "4:10" },
                                    new Track { Id = 4, Description = "Don’t You Remember", Duration = "4:03" },
                                    new Track { Id = 5, Description = "Set Fire to the Rain", Duration = "4:02" },
                                    new Track { Id = 6, Description = "He Won’t Go", Duration = "4:38" },
                                    new Track { Id = 7, Description = "Take It All", Duration = "3:48" },
                                    new Track { Id = 8, Description = "I'll Be Waiting", Duration = "4:02" },
                                    new Track { Id = 9, Description = "One and Only", Duration = "5:48" },
                                    new Track { Id = 10, Description = "Love Song", Duration = "5:16" },
                                    new Track { Id = 11, Description = "Someone Like You", Duration = "4:45" },
                                },
                                 SiteLanguages = languages,
                                 Title = "Adele 21 ES",
                                 OgTitle = "Página Adele 21 ES",
                                 Robots = "Adele 21 ES",
                                 MetaDescription = "Página Adele 21 ES"
                            },
                            new AudioDetailModel
                            {
                                Name = "Linkin Park",
                                Description = "Linkin Park es una banda estadounidense de rock alternativo procedente de Agoura Hills, California formada en 1996. Integrada por Mike Shinoda, Dave Farrell, Joe Hahn, Brad Delson, Rob Bourdon y Chester Bennington, este último como voz principal.",
                                Image = "LinkinPark.jpg",
                                BannerImage = "LinkinPark-banner.jpg",
                                Year = 2015 ,
                                ContentType = Models.ContentType.Audio,
                                ImdbRating = 8.5M,
                                TrackList = new List<Track>
                                {
                                    new Track { Id = 1, Description = "Somewhere I Belong", Duration = "3:48" },
                                    new Track { Id = 2, Description = "Lying from You (Live in Texas)", Duration = "3:43" },
                                    new Track { Id = 3, Description = "Papercut", Duration = "4:10" },
                                    new Track { Id = 4, Description = "Points of Authority", Duration = "4:03" },
                                    new Track { Id = 5, Description = "Runaway (live)", Duration = "4:02" },
                                    new Track { Id = 6, Description = "Faint", Duration = "4:38" },
                                    new Track { Id = 7, Description = "From the Inside (Live in Texas)", Duration = "3:48" },
                                    new Track { Id = 8, Description = "P5hng Me A*wy (Live in Texas)", Duration = "4:02" },
                                    new Track { Id = 9, Description = "Numb", Duration = "5:48" },
                                    new Track { Id = 10, Description = "Crawling", Duration = "5:16" },
                                    new Track { Id = 11, Description = "In The End", Duration = "4:45" },
                                    new Track { Id = 12, Description = "One Step Closer", Duration = "4:45" }
                                },
                                 SiteLanguages = languages,
                                 Title = "Linkin Park ES",
                                 OgTitle = "Página Linkin Park ES",
                                 Robots = "Linkin Park ES",
                                 MetaDescription = "Página Linkin Park ES"
                            }
                        },
                        Tvs = new List<TvDetailModel>
                        {
                            new TvDetailModel
                            {
                                Name = "All American",
                                Season = 1,
                                Description = "All American es una serie de televisión de drama deportivo estadounidense, creada por April Blair que se estrenó en The CW el 10 de octubre de 2018. La serie está inspirada en la vida del jugador profesional de fútbol americano Spencer Paysinger, con Daniel Ezra en el papel principal. En enero de 2020, The CW renovó la serie para una tercera temporada que se estrenó el 18 de enero de 2021.",
                                ImdbRating= 9.2M,
                                Year = 2019,
                                Image = "AllAmericanS1.jpg",
                                BannerImage = "AllAmericanS1-banner.jpg",
                                Cast = "Teste",
                                Copyright = "Teste",
                                Director = "Teste",
                                Genre = "Teste",
                                Released = "Teste",
                                Studio = "Teste",
                                ContentType = Models.ContentType.TV,
                                Episodes = new List<Episode>
                                {
                                    new Episode { Id = 1, Description = "Pilot", Duration = "1:05" },
                                    new Episode { Id = 2, Description = "99 Problems", Duration = "1:02" },
                                    new Episode { Id = 3, Description = "i", Duration = "0:55" },
                                    new Episode { Id = 4, Description = "Lose Yourself", Duration = "0:59" },
                                    new Episode { Id = 5, Description = "All We Got", Duration = "1:00" },
                                },
                                 SiteLanguages = languages,
                                 Title = "All American ES",
                                 OgTitle = "Página All American ES",
                                 Robots = "All American ES",
                                 MetaDescription = "Página All American ES"
                            },
                            new TvDetailModel
                            {
                                Name = "The Big Bang Theory",
                                Season = 1,
                                Description = "The Big Bang Theory (también conocida como La teoría del Big Bang en Hispanoamérica o Big Bang​ en ingles) es una comedia de situación estadounidense estrenada el 24 de septiembre de 2007 y finalizada el 16 de mayo de 2019 por la cadena CBS. Fue producida por la Warner Bros y Chuck Lorre.",
                                ImdbRating= 8.2M,
                                Year = 2007,
                                Image = "TheBigBangTheoryS1.jpg",
                                BannerImage = "TheBigBangTheoryS1-banner.jpg",
                                Cast = "Teste",
                                Copyright = "Teste",
                                Director = "Teste",
                                Genre = "Teste",
                                Released = "Teste",
                                Studio = "Teste",
                                ContentType = Models.ContentType.TV,
                                Episodes = new List<Episode>
                                {
                                    new Episode { Id = 0, Description = "Unaired Pilot", Duration = "1:05" },
                                    new Episode { Id = 1, Description = "Pilot", Duration = "1:05" },
                                    new Episode { Id = 2, Description = "The Big Bran Hypothesis", Duration = "1:02" },
                                    new Episode { Id = 3, Description = "The Fuzzy Boots Corollary", Duration = "0:55" },
                                    new Episode { Id = 4, Description = "The Luminous Fish Effect", Duration = "0:59" },
                                    new Episode { Id = 5, Description = "The Hamburger Postulate", Duration = "1:00" },
                                },
                                 SiteLanguages = languages,
                                 Title = "The Big Bang Theory ES",
                                 OgTitle = "Página The Big Bang Theory ES",
                                 Robots = "The Big Bang Theory ES",
                                 MetaDescription = "Página The Big Bang Theory ES"
                            },
                            new TvDetailModel
                            {
                                Name = "How to Get Away with Murder",
                                Season = 1,
                                Description = "How to Get Away with Murder (Cómo defender a un asesino​ en España y Lecciones del crimen​ en Hispanoamérica ) es una serie televisiva estadounidense de drama legal creada por Peter Nowalk y producida por Shonda Rhimes para la cadena ABC,​ estrenada el 25 de septiembre de 2014.",
                                ImdbRating= 8.2M,
                                Year = 2014,
                                Image = "htgawmS1.jpg",
                                BannerImage = "htgawmS1-banner.jpg",
                                Cast = "Teste",
                                Copyright = "Teste",
                                Director = "Teste",
                                Genre = "Teste",
                                Released = "Teste",
                                Studio = "Teste",
                                ContentType = Models.ContentType.TV,
                                Episodes = new List<Episode>
                                {
                                    new Episode { Id = 1, Description = "Pilot", Duration = "1:05" },
                                    new Episode { Id = 2, Description = "It's All Her Fault", Duration = "1:02" },
                                    new Episode { Id = 3, Description = "Smile, or Go to Jail", Duration = "0:55" },
                                    new Episode { Id = 4, Description = "Let's Get to Scooping", Duration = "0:59" },
                                    new Episode { Id = 5, Description = "We're Not Friends", Duration = "1:00" },
                                },
                                 SiteLanguages = languages,
                                 Title = "How to Get Away with Murder ES",
                                 OgTitle = "Página How to Get Away with Murder ES",
                                 Robots = "How to Get Away with Murder ES",
                                 MetaDescription = "Página How to Get Away with Murder ES"
                            },
                            new TvDetailModel
                            {
                                Name = "The Simpsons",
                                Season = 1,
                                Description = "Los Simpson (en inglés: The Simpsons) es una serie estadounidense de comedia, en formato de animación, creada por Matt Groening para Fox Broadcasting Company y emitida en varios países del mundo. La serie es una sátira de la sociedad estadounidense que narra la vida y el día a día de una familia de clase media de ese país (cuyos miembros son Homer, Marge, Bart, Lisa y Maggie Simpson) que vive en un pueblo ficticio llamado Springfield.",
                                ImdbRating= 8.7M,
                                Year = 1989,
                                Image = "TheSimpsonsS1.jpg",
                                BannerImage = "TheSimpsonsS1-banner.jpg",
                                Cast = "Teste",
                                Copyright = "Teste",
                                Director = "Teste",
                                Genre = "Teste",
                                Released = "Teste",
                                Studio = "Teste",
                                ContentType = Models.ContentType.TV,
                                Episodes = new List<Episode>
                                {
                                    new Episode { Id = 1, Description = "Simpsons Roasting on an Open Fire", Duration = "1:05" },
                                    new Episode { Id = 2, Description = "Bart the Genius", Duration = "1:02" },
                                    new Episode { Id = 3, Description = "Homer's Odyssey", Duration = "0:55" },
                                    new Episode { Id = 4, Description = "There's No Disgrace Like Home", Duration = "0:59" },
                                    new Episode { Id = 5, Description = "Bart the General", Duration = "1:00" },
                                },
                                 SiteLanguages = languages,
                                 Title = "The Simpsons ES",
                                 OgTitle = "Página The Simpsons ES",
                                 Robots = "The Simpsons ES",
                                 MetaDescription = "Página The Simpsons ES"
                            }
                        },
                        Categories = new List<Item>
                        {
                            new Item(1, "Película"),
                            new Item(2, "Canción"),
                            new Item(3, "Serie")
                        },
                        Dates = new List<Item>
                        {
                            new Item(1, "01/01/2001"),
                            new Item(2, "02/02/2002"),
                            new Item(3, "03/03/2003")
                        },
                        FlightNumber = new List<Item>
                        {
                            new Item(1, "12345"),
                            new Item(2, "54321"),
                            new Item(3, "99887")
                        },
                        From = new List < Item >
                        {
                            new Item(1, "Lisboa"), new Item(2, "Brasil"), new Item(3, "España")
                        },
                        Genres = new List<Item>
                        {
                            new Item(1, "Drama"),
                            new Item(2, "Ficción"),
                            new Item(3, "Horror")
                        },
                        Languages = new List<Item>
                        {
                            new Item(1, "PT"),
                            new Item(2, "EN"),
                            new Item(3, "ES")
                        },
                        SortBy = new List<Item>
                        {
                            new Item(1, "Asc"),
                            new Item(3, "Desc")
                        },
                        Subtitles = new List<Item>
                        {
                            new Item(1, "PT"), new Item(2, "EN"), new Item(3, "ES")
                        },
                        To = new List<Item>
                        {
                            new Item(1, "Lisboa") , new Item(2, "Brasil") , new Item(3, "España")
                        },
                        Modal = new ModalModel
                        {
                            Dates = new List<Item>
                            {
                                new Item(1, "01/01/2001"), new Item(2, "02/02/2002"), new Item(3, "03/03/2003")
                            },
                            FlightNumber = new List<Item>
                            {
                                new Item(1, "12345"), new Item(2, "54321"), new Item(3, "99887")
                            },
                            From = new List <Item>
                            {
                                new Item(1, "Lisboa") , new Item(2, "Brasil") , new Item(3, "España")
                            },
                            To = new List<Item>
                            {
                                new Item(1, "Lisboa") , new Item(2, "Brasil") , new Item(3, "España")
                            }
                        },
                        SiteLanguages = languages,
                        Title = "Index ES",
                        Name= "Index",
                        MetaDescription = "Página Index ES",
                        OgTitle = "Página Index ES",
                        Robots = "Index ES"
                    }}
                },
            };

            return index;
        }
    }
}
