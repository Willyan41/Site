using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Gerenciador
{
    class IdentidadeGerenciador : GerenciadorBase
    {
        public IdentidadeGerenciador()
        {
            _context = new Context.SiteContext();
        }


        public void AdicionarIdentidade(Identidade identidade)
        {
            try
            {
                if (identidade != null)
                {
                    if(identidade.Id == 0)
                    {
                        _context.Identidade.Add(identidade);
                    }
                    _context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Identidade RecuperarIdentidadeId(int id)
        {
            return _context.Identidade.Find(id);
        }

        public IQueryable<Identidade> RecuperarIdentidade()
        {
            return _context.Identidade.Select(c => new Identidade
            {
                Id = c.Id,
                RegistroGeral = c.RegistroGeral,
                OrgaoEmissor = c.OrgaoEmissor,
                UF = c.UF,
            });
            
        }

        public void ApagarIdentidade(Identidade identidade)
        {
            try
            {
                if(identidade != null)
                {
                    if(identidade.Id != 0)
                    {
                        _context.Identidade.Remove(identidade);
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
