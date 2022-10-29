namespace GeneratePagoFromBlazor.Models
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            this.Name = "WIG";
            this.Data = DateTime.Now;
            this.Items = new List<IndexItemViewModel>
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
                    };
            this.Privacy = new PrivacyViewModel
            {
                Name = "WIG Privacy",
                Data = DateTime.Now
            };
        }

        public string Name { get; set; }

        public DateTime Data { get; set; }

        public PrivacyViewModel Privacy { get; set; }

        public List<IndexItemViewModel> Items { get; set; }
    }

    public class IndexItemViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
    }
}
