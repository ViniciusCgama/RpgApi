using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Models.Enuns;
using System.Collections.Generic;
using System.Linq;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagensExercicioController : ControllerBase
    {
        private static List<Personagem> personagens = new List<Personagem>()
        {
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=110, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=110, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };
        [HttpGet("GetByNome/{nome}")]
        public IActionResult GetByNome(string nome)
        {
            List<Personagem> listaNome = personagens.FindAll(p => p.Nome == nome);
            
            if (listaNome == null || listaNome.Count == 0)
            {
                return NotFound("Nome não encontrado.");
            }
            
            return Ok(listaNome);
        }

        [HttpPost("PostValidacao")]
        public IActionResult PostValidacao([FromBody] Personagem novoPersonagem)
        {
            if (novoPersonagem.Inteligencia == 0 || novoPersonagem.Defesa > 30)
                return BadRequest("Inteligência não pode ter um valor maior que 30 ou Defesa menor que 10.");
            
            if (novoPersonagem.Defesa < 10)
                return BadRequest("Defesa deve ser maior ou igual a 10.");
            
            personagens.Add(novoPersonagem);
            return Ok(personagens);
        }

        [HttpPost("PostValidacaoMago")]
       public IActionResult PostValidacaoMago([FromBody] Personagem novoPersonagem)
{
    if (novoPersonagem == null)
    {
        return BadRequest("Dados de personagem inválidos");
    }

    if (novoPersonagem.Classe != ClasseEnum.Mago)
    {
        return BadRequest("Apenas personagens da classe Mago podem ser adicionados.");
    }

    if (novoPersonagem.Inteligencia < 35)
    {
        return BadRequest("A inteligência deve ser no mínimo 35 para um personagem Mago.");
    }

    return Ok("Personagem adicionado com sucesso");
}

      [HttpGet("GetClerigoMago")]
    public IActionResult GetClerigoMago()
    {
    List<Personagem> listaClasse = personagens.Where(p => p.Classe != ClasseEnum.Cavaleiro).ToList();
    
    var listaOrdenada = listaClasse.OrderByDescending(p => p.PontosVida).ToList();
    
    return Ok(listaOrdenada);
    }

        [HttpGet("GetEstatisticas")]
        public IActionResult GetEstatisticas()
        {
            int quantidadeDePersonagens = personagens.Count;
             
            int somatorioDeInteligencia = personagens.Sum(p => p.Inteligencia);
            
            var estatisticas = new
            {
                QuantidadeDePersonagens = quantidadeDePersonagens,
                SomatorioDeInteligencia = somatorioDeInteligencia
            };
            
            return Ok(estatisticas);
        }

        [HttpGet("GetByClasse/{classeEnum}")]
        public IActionResult GetByClasse(int classeEnum)
        {
            ClasseEnum classe = (ClasseEnum)classeEnum;

            List<Personagem> listaClasse = personagens.FindAll(p => p.Classe == classe);

            if (listaClasse == null || listaClasse.Count == 0)
            {
                return NotFound("Nenhum personagem encontrado com a classe informada.");
            }

            return Ok(listaClasse);
        }
    }
}