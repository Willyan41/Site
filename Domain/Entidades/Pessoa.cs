using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entidades
{
    class Pessoa : EntidadeBase
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public Contato Contato { get; set; }
        public Deficiencia Deficiencia { get; set; }
        public TipoSanguineo TipoSanguineo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Naturalidade Naturalidade { get; set; }
        public Residencia Residencia { get; set; }

    }
}
