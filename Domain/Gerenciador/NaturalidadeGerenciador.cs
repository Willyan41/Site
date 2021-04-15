using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Gerenciador
{
    class NaturalidadeGerenciador : GerenciadorBase
    {
        public NaturalidadeGerenciador()
        {
            _context = new Context.SiteContext();
        }

        public void AdicionarNaturalidade(Naturalidade naturalidade)
        {
            try
            {
                if (naturalidade != null)
                {
                    if (naturalidade.Id == 0)
                    {
                        _context.Naturalidade.Add(naturalidade);
                    }
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Naturalidade RecuperarNaturalidadeId(int id)
        {
            return _context.Naturalidade.Find(id);
        }

        public IQueryable<Naturalidade> RecuperarNaturalidade()
        {
            return _context.Naturalidade.Select(c => new Naturalidade
            {
                Id = c.Id,
                Nacionalidade = c.Nacionalidade,
                Naturalidad = c.Naturalidad,
                UF = c.UF,
            });
        }

        public void ApagarNaturalidade(Naturalidade naturalidade)
        {
            try
            {
                if(naturalidade!= null)
                {
                    if (naturalidade.Id != 0)
                    {
                        _context.Naturalidade.Remove(naturalidade);
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
