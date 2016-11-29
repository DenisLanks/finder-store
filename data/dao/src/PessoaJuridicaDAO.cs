using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSEntity;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class PessoaJuridicaDAO : DAO<PessoaJuridica, long>
    {
        public PessoaJuridicaDAO():base(){
            dbSet = context.PessoasJuridicas;
        }
       public PessoaJuridicaDAO(DbContextOptions options):base(options)
        {
            dbSet = context.PessoasJuridicas;
        }

        public PessoaJuridicaDAO(FSDbContext context) : base(context)
        {
            dbSet = context.PessoasJuridicas;
        }
    }
}
