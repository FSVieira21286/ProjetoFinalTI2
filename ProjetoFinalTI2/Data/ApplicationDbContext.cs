using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalTI2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinalTI2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
               protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Medico>().HasData(
                new Medico { MedicoId = 1, Nome = "JoÃ£o Joca", Fotografia = "JoaoJoca.jpg", Especialidade = "Genecologista" },
                new Medico { MedicoId = 2, Nome = "Paulo Guedes", Fotografia = "PauloGuedes.jpg", Especialidade = "Morto" }
                );

            modelBuilder.Entity<Medicamento>().HasData(
                new Medicamento { MedicId = 1, Nome = "Benuron", Preco = 5 }
                );

            modelBuilder.Entity<Utente>().HasData(
                new Utente { UtenteId = 1, Nome = "Filipe Vieira", DataNasc = new DateTime(2000, 12, 9), NIF = "123456789" },
                new Utente { UtenteId = 2, Nome = "Gabriel Bonet", DataNasc = new DateTime(1998, 3, 27), NIF = "987654321" }
                );

            modelBuilder.Entity<MedicamentoReceita>().HasData(
                new MedicamentoReceita {Id = 1, ReceitaFk = 1, MedicamentoFk = 1}
                );

            modelBuilder.Entity<Receita>().HasData(
                new Receita { ReceitaId = 1, Preco = 5 , ReceitaData = DateTime.Now, MedicoIDFK = 2, UtenteIDFK = 2}
                );

            //relacionamento medicamento - receita
            // signal R - chat medico utente

        }
        //Representar as Tabelas da BD
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Medicamento> Medicamento { get; set; }
        public DbSet<Utente> Utente { get; set; }
        public DbSet<MedicamentoReceita> MedicamentoReceita { get; set; }
        public DbSet<Receita> Receita { get; set; }

        //ola filipe!!
    }
}
