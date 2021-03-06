using System;
using Microsoft.EntityFrameworkCore;
using FSEntity;
namespace DAO
{
    public class FSDbContext: DbContext
    {
        public FSDbContext(){
        }
        public FSDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Sexo> Sexos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
         
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){

        }
    }
}