using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSEntity;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class PessoaFisicaDAO: DAO<PessoaFisica,long>
    {
        public PessoaFisicaDAO():base()
        {
            dbSet = context.PessoasFisicas;
        }

        public PessoaFisicaDAO(DbContextOptions options):base(options)
        {
            dbSet = context.PessoasFisicas;
        }

        public PessoaFisicaDAO(FSDbContext context) : base(context)
        {
            dbSet = context.PessoasFisicas;
        }
    }
}