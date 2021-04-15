using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Gerenciador
{
    class ResidenciaGerenciador : GerenciadorBase
    {
        public ResidenciaGerenciador()
        {
            _context = new Context.SiteContext();
        }

        public void AdicionarResidencia(Residencia residencia)
        {
            try
            {
                if (residencia != null)
                {
                    if (residencia.Id == 0)
                    {
                        _context.Residencia.Add(residencia);
                    }
                    _context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Residencia RecuperarResidenciaId(int id)
        {
            return _context.Residencia.Find(id);
        }

        public IQueryable<Residencia> RecuperarResidencia()
        {
            return _context.Residencia.Select(c => new Residencia
            {
                Id = c.Id,
                Bairro = c.Bairro,
                CEP = c.CEP,
                Cidade = c.Cidade,
                Complemento = c.Complemento,
                Logradouro = c.Logradouro,
                Numero = c.Numero,
                UF = c.UF,

            });
        }

        public void ApagarResidencia(Residencia residencia)
        {
            try
            {
                if(residencia != null)
                {
                    if(residencia.Id != 0)
                    {
                        _context.Residencia.Remove(residencia);
                        _context.SaveChanges();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
