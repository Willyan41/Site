using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entidades
{
    class Contato : EntidadeBase
    {
        public int TelFixo { get; set; }
        public int TelCel { get; set; }
        public string Email { get; set; }


    }
}
