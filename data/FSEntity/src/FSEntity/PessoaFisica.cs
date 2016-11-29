using System;

namespace FSEntity{
    public class PessoaFisica : Pessoa{
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
        public byte SexoID { get; set; }
        public virtual Sexo Sexo { get; set; }

    }
}