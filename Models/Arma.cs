using System;
using System.Collections.Generic;
using System.Linq;


namespace RpgApi.Models
{
    public class Armas
    {
        public int IdF { get; set; }
        public string NomeF { get; set; }
        public int DanoF { get; set; }
        public Personagem Personagem { get; set; }
        public int PersonagemId { get; set; }
 internal static List<Armas> FindAll(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
 }