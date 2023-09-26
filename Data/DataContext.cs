using Microsoft.EntityFrameworkCore;
using RpgApi.Models;
using RpgApi.Models.Enuns;


namespace RpgApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Personagem> TB_PERSONAGENS { get; set; }
        public DbSet<Armas> TB_ARMAS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Personagem>()
             .HasKey(personagem => personagem.Id);

            modelBuilder.Entity<Personagem>().HasData(
                new Personagem() { Id = 1, Nome = "Frodo", PontosVida = 100, Forca = 17, Defesa = 23, Inteligencia = 33, Classe = ClasseEnum.Cavaleiro },
                new Personagem() { Id = 2, Nome = "Sam", PontosVida = 100, Forca = 15, Defesa = 25, Inteligencia = 30, Classe = ClasseEnum.Cavaleiro },
                new Personagem() { Id = 3, Nome = "Galadriel", PontosVida = 100, Forca = 18, Defesa = 21, Inteligencia = 35, Classe = ClasseEnum.Clerigo },
                new Personagem() { Id = 4, Nome = "Gandalf", PontosVida = 110, Forca = 18, Defesa = 18, Inteligencia = 37, Classe = ClasseEnum.Mago },
                new Personagem() { Id = 5, Nome = "Hobbit", PontosVida = 110, Forca = 20, Defesa = 17, Inteligencia = 31, Classe = ClasseEnum.Cavaleiro },
                new Personagem() { Id = 6, Nome = "Celeborn", PontosVida = 100, Forca = 21, Defesa = 13, Inteligencia = 34, Classe = ClasseEnum.Clerigo },
                new Personagem() { Id = 7, Nome = "Radagast", PontosVida = 100, Forca = 25, Defesa = 11, Inteligencia = 35, Classe = ClasseEnum.Mago }
            );

               modelBuilder.Entity<Armas>()
        .ToTable("TB_ARMAS")
        .HasKey(arma => arma.IdF);

    modelBuilder.Entity<Armas>().HasData(
                new Armas() { NomeF = "Espada de cria demoniaca", DanoF = 50, IdF = 1 },
                new Armas() { NomeF = "Faca envenenada", DanoF = 45,  IdF = 2 },
                new Armas() { NomeF = "Arco da fenda do vazio", DanoF = 75, IdF = 3 },
                new Armas() { NomeF = "Machado do Cleyton", DanoF = 69,  IdF = 4 },
                new Armas() { NomeF = "Chicote do Desejo", DanoF = 35,  IdF = 5 },
                new Armas() { NomeF = "Baseball BAT", DanoF = 42,  IdF = 6 },
                new Armas() { NomeF = "Manopla do grande roxo", DanoF = 50,  IdF = 7 }
            );
        }
    }
}