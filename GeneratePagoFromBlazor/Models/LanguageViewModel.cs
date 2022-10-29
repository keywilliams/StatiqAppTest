namespace GeneratePagoFromBlazor.Models
{
    public class LanguageViewModel
    {
        public Dictionary<string, IndexViewModel> IndexCollection { get; set; }

        public LanguageViewModel()
        {
            this.IndexCollection = new Dictionary<string, IndexViewModel>
            {
                {"pt", new IndexViewModel
                {
                    Name = "WIG PT",
                    Data = DateTime.Now,
                    Items = new List<IndexItemViewModel>
                    {
                         new IndexItemViewModel
                         {
                             Name = "Titanic",
                             Description = "O RMS Titanic foi um navio de passageiros britânico operado pela White Star Line e construído pelos estaleiros da Harland and Wolff, em Belfast.",
                             Image = "Titanic.jpg"
                         },
                         new IndexItemViewModel
                         {
                             Name = "Matrix",
                             Description = "Um jovem programador é atormentado por estranhos pesadelos nos quais sempre está conectado por cabos a um imenso sistema de computadores do futuro. À medida que o sonho se repete, ele começa a levantar dúvidas sobre a realidade.",
                             Image = "Matrix.jpg"
                         },
                         new IndexItemViewModel
                         {
                             Name = "Avatar",
                             Description = "No exuberante mundo alienígena de Pandora vivem os Na'vi, seres que parecem ser primitivos, mas são altamente evoluídos. Como o ambiente do planeta é tóxico, foram criados os avatares, corpos biológicos controlados pela mente humana que se movimentam livremente em Pandora.",
                             Image = "Avatar.jpg"
                         },
                         new IndexItemViewModel
                         {
                             Name = "Hulk",
                             Description = "Bruce Banner é um cientista e trabalha ao lado de sua grande paixão, a bela Betty Ross, em um projeto que envolve a reconstituição de tecidos com a utilização da radiação gama.",
                             Image = "Hulk.jpg"
                         }
                    },
                    Privacy = new PrivacyViewModel
                    {
                        Name = "WIG Privacy PT",
                        Data = DateTime.Now
                    }
                }},
                {"en", new IndexViewModel
                {
                    Name = "WIG EN",
                    Data = DateTime.MaxValue,
                    Items = new List<IndexItemViewModel>
                    {
                         new IndexItemViewModel
                         {
                             Name = "Titanic",
                             Description = "RMS Titanic was the largest ship afloat at the time she entered service and the second of three Olympic-class ocean liners operated by the White Star Line. She was built by the Harland and Wolff shipyard in Belfast.",
                             Image = "Titanic.jpg"
                         },
                         new IndexItemViewModel
                         {
                             Name = "Matrix",
                             Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis.[a] It is the first installment in The Matrix film series, starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, it depicts a dystopian future in which humanity is unknowingly trapped inside the Matrix, a simulated reality that intelligent machines have created to distract humans while using their bodies as an energy source.",
                             Image = "Matrix.jpg"
                         },
                         new IndexItemViewModel
                         {
                             Name = "Avatar",
                             Description = "Avatar (also marketed as James Cameron's Avatar) is a 2009 American epic science fiction film directed, written, produced, and co-edited by James Cameron and starring Sam Worthington, Zoe Saldana, Stephen Lang, Michelle Rodriguez and Sigourney Weaver. It is set in the mid-22nd century when humans are colonizing Pandora, a lush habitable moon of a gas giant in the Alpha Centauri star system, in order to mine the valuable mineral unobtanium.",
                             Image = "Avatar.jpg"
                         },
                         new IndexItemViewModel
                         {
                             Name = "Hulk",
                             Description = "Hulk (also known as The Hulk) is a 2003 American superhero film based on the Marvel Comics character of the same name, created by Stan Lee and Jack Kirby. Directed by Ang Lee and written by James Schamus, Michael France, and John Turman from a story by Schamus, it stars Eric Bana as Bruce Banner/Hulk, alongside Jennifer Connelly, Sam Elliott, Josh Lucas, and Nick Nolte.",
                             Image = "Hulk.jpg"
                         }
                    },
                    Privacy = new PrivacyViewModel
                    {
                        Name = "WIG Privacy EN",
                        Data = DateTime.MaxValue
                    }
                }},
                {"es", new IndexViewModel
                {
                    Name = "WIG ES",
                    Data = DateTime.MinValue,
                    Items = new List<IndexItemViewModel>
                    {
                         new IndexItemViewModel
                         {
                             Name = "Titanic",
                             Description = "Siendo construido entre 1909 y 1912 en los astilleros de Harland & Wolff de Belfast, el Titanic constituía el segundo buque de un trío de grandes transatlánticos (siendo el primero el RMS Olympic y el tercero el HMHS Britannic), propiedad de la compañía naviera White Star Line, conocidos como la clase Olympic.",
                             Image = "Titanic.jpg"
                         },
                         new IndexItemViewModel
                         {
                             Name = "Matrix",
                             Description = "The Matrix (conocida como Matrix en Hispanoamérica) es una película de acción y ciencia ficción de 1999 escrita y dirigida por las hermanas Wachowski y protagonizada por Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss y Hugo Weaving. Representa un futuro distópico en el que la humanidad está atrapada sin saberlo dentro de una realidad simulada llamada Matrix, que las máquinas inteligentes han creado para distraer a los humanos mientras usan sus cuerpos como fuente de energía en campos de cultivo.",
                             Image = "Matrix.jpg"
                         },
                         new IndexItemViewModel
                         {
                             Name = "Avatar",
                             Description = "Avatar (comercializada como Avatar de James Cameron) es una película épica de ciencia ficción militar, Animación y estadounidense de 2009,6​7​ escrita, producida y dirigida por James Cameron y protagonizada por Sam Worthington, Zoe Saldaña, Sigourney Weaver, Stephen Lang y Michelle Rodriguez.",
                             Image = "Avatar.jpg"
                         },
                         new IndexItemViewModel
                         {
                             Name = "Hulk",
                             Description = "Hulk es una película de 2003 basada en el personaje ficticio de Marvel Comics del mismo nombre.2​ Ang Lee dirigió el filme, que es protagonizado por Eric Bana como el Dr. Bruce Banner, así como Jennifer Connelly, Sam Elliott, Nick Nolte y Josh Lucas.",
                             Image = "Hulk.jpg"
                         }
                    },
                    Privacy = new PrivacyViewModel
                    {
                        Name = "WIG Privacy ES",
                        Data = DateTime.MinValue
                    }
                }}
            };
        }
    }
}
