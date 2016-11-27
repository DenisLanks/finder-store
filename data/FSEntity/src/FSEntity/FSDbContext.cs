using System;
using Microsoft.EntityFrameworkCore;
namespace FSEntity.Context
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
    }
}