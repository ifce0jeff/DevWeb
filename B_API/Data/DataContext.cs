using System.Collections.Generic;
using B_API.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace B_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Restaurante>()
                .HasData(
                    new List<Restaurante>(){
                        new Restaurante() {
                            Id = 1,
                            Nome = "McDonald",
                            Endereco = "McDonald",
                            Preco = 1,
                            Categoria = 2,
                            Especialidade = "Laches",
                            Status = "Aberto"
                        },
                        new Restaurante() {
                            Id = 2,
                            Nome = "LaParrilla",
                            Endereco = "LaParrilla",
                            Preco = 2,
                            Categoria = 3,
                            Especialidade = "Hamburguer",
                            Status = "Fechado"
                        },
                    }
                );

            builder.Entity<Usuario>()
                .HasData(
                    new List<Usuario>(){
                        new Usuario() {
                            Id = 1,
                            Nome = "Iesus",
                            Email = "iesus90@gmail.com",
                            Senha = "1234",
                            Facebook = "Iesus Silva",
                            Twitter = "iesus",
                            Sobre = "Gosto de Comer"
                        },
                        new Usuario() {
                            Id = 2,
                            Nome = "Jefferson",
                            Email = "Jeff@gmail.com",
                            Senha = "4321",
                            Facebook = "Jefferson Nunes",
                            Twitter = "Jeff",
                            Sobre = "Gosto de conhecer novos lugares"
                        },
                    }
                );

                builder.Entity<Reserva>()
                .HasData(
                    new List<Reserva>(){
                        new Reserva() {
                            Id = 1,
                            RestauranteId = 2,
                            Data = "04/03/2020",
                            Hora = "19:00",
                            UsuarioId = 2,
                        },
                        new Reserva() {
                            Id = 2,
                            RestauranteId = 1,
                            Data = "04/03/2020",
                            Hora = "13:00",
                            UsuarioId = 1,
                        },
                    }
                );
        }

    }
}