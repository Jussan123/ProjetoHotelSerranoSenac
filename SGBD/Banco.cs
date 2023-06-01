/* Módulo SGBD(Sitema de Gerenciamento de Banco de Dados) Conexão com o Banco de Dados
* Descrição: Classe responsável por realizar a conexão com o banco de dados AWS
* Autor: Jussan Igor da Silva
* Data de criação: 01/06/2023
* Versão: 1.0
* Data da última modificação: 01/06/2023
* Autor da última modificação: Jussan Igor da Silva
* Modificações realizadas: Criação da classe
*/

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Model;
using System.Data.SqlClient;
using System.Linq;

namespace Banco
{
    public class DataBase : DbContext
    {
        // criação das tabelas no banco de dados pelo Entity Framework
        public DbSet<Hotel> Hoteis { get; set; } // padrão de nomeclatura do Entity Framework


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // criação das chaves primárias e estrangeiras das tabelas no banco de dados pelo Entity Framework
            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(e => e.hotelId);//chave primária
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//configuração do banco de dados
        {
            if (!optionsBuilder.IsConfigured)//se não estiver configurado
            {
                try
                {
                    string connectionAWS = GetConnectionStringAWS();//conexão com o banco de dados na AWS
                    optionsBuilder.UseMySql(connectionAWS, ServerVersion.AutoDetect(connectionAWS));//configuração do banco de dados na AWS
                }
                catch
                {
                    Console.WriteLine("Não foi possível conectar a AWS");//mensagem de erro
                }
            }
        }

        public static string GetConnectionStringAWS()//conexão com o banco de dados na AWS
        {
            string serverName = "awsjussan.cbrcalzcoxol.us-east-1.rds.amazonaws.com";//nome do servidor
            //string serverName = "RDS MySQL";
            string databaseName = "HotelSerranoSenac"; //nome do banco de dados
            string username = "admin"; //nome do usuário
            string password = "jussan123"; //senha do usuário

            string connectionString = $"Server={serverName};Database={databaseName};User ID={username};Password={password};";//string de conexão com o banco de dados

            return connectionString;//retorna a string de conexão com o banco de dados
        }
    }
}