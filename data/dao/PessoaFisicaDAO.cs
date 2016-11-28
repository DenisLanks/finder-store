using FSEntity;
namespace DAO
{
    public class PessoaFisicaDAO: DAO<PessoaFisica,long>
    {
       public override PessoaFisica[] All(){
         return   context.PessoasFisicas.ToArray();
       } 
    }
}