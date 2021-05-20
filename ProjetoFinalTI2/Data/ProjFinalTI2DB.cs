sing ProjetoFinalTI2.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalTI2.Data
{
    /// <summary>
    /// esta classe representa a Base de Dados a ser utilizada neste projeto
    /// </summary>
    public class ProjFinalTI2DB : DbContext
    { 

        public ProjFinalTI2DB(DbContextOptions<ProjFinalTI2DB> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Medico>().HasData(
                new Medico { MedicoId = 1, Nome = "JoÃ£o Joca" },
                new Medico { MedicoId = 2, Nome = "Paulo Guedes" }
                );

            modelBuilder.Entity<Medicamento>().HasData(
                new Medicamento { MedicId = 1, Nome = "Benuron", Preco = 5 }
                );

            modelBuilder.Entity<Utente>().HasData(
                new Utente { UtenteId = 1, Nome = "Filipe Vieira", DataNasc = new DateTime(2000, 12, 9), NIF = "123456789" },
                new Utente { UtenteId = 2, Nome = "Gabriel Bonet", DataNasc = new DateTime(1998, 3, 27), NIF = "987654321" }
                );

            modelBuilder.Entity<MedicoReceita>().HasData(
                new ReceitaMedica { }
                );

            modelBuilder.Entity<Fotografias>().HasData(
                new Fotografias { Id = 1, Fotografia = "JoaoJoca.jpg", MedicoFK = 1 }
                );


            modelBuilder.Entity<Receita>().HasData(
                new MedicoReceita { }
                );

            //relacionamento medicamento - receita
            // signal R - chat medico utente

        }
            //Representar as Tabelas da BD
            public DbSet<Medico> Medico { get; set; }
            public DbSet<Medicamento> Medicamento { get; set; }
            public DbSet<Utente> Utente { get; set; }
            public DbSet<MedicoReceita> MedicoReceita { get; set; }
            public DbSet<Fotografias> Fotografias { get; set; }
            public DbSet<Receita> Receita { get; set; }

        }
    }
