using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProjetoHotelSerranoSenac.Models;
using System.Data.SqlClient;
using System.Linq;

namespace Banco
{
    public class DataBase : DbContext
    {
        public DataBase() { }
        public DataBase(DbContextOptions<DataBase> options) : base(options) { }
        
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ReservaProduto> ReservaProduto { get; set; }
        public DbSet<ReservaServico> ReservaServico { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                try
                {
                    string connectionAWS = GetConnectionStringAWS();
                    optionsBuilder.UseMySql(connectionAWS, ServerVersion.AutoDetect(connectionAWS));
                }
                catch
                {
                    Console.WriteLine("Não foi possível conectar a AWS");
                }
            }
        }

        public static string GetConnectionStringAWS()
        {
            string serverName = "awsjussan.cbrcalzcoxol.us-east-1.rds.amazonaws.com";
            //string serverName = "RDS MySQL";
            string databaseName = "HotelSerranoSenac";
            string username = "admin";
            string password = "jussan123";

            string connectionString = $"Server={serverName};Database={databaseName};User ID={username};Password={password};";

            return connectionString;
        }
    }
}