using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entidades
{
    class Identidade : EntidadeBase
    {
        public int RegistroGeral { get; set; }
        public string OrgaoEmissor { get; set; }
        public UF UF { get; set; }

    }
}
