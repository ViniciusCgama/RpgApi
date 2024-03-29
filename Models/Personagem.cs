using RpgApi.Models.Enuns;

namespace RpgApi.Models
{
    public class Personagem
    {
        public int Id { get; set; }  
        public string Nome { get; set; }
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        public ClasseEnum Classe { get; set; }
        public byte[]? FotoPersonagem { get; set; }

        [JsonIgnore]
        public Usuario? Usuario { get; set; }

        [JsonIgnore]

        public Arma Arma { get; set; }
        internal static List<Personagem> FindAll(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}