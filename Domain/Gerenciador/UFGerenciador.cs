using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Gerenciador
{
    class UFGerenciador : GerenciadorBase
    {
        public UFGerenciador()
        {
            _context = new Context.SiteContext();
        }

        public void AdicionarUF(UF uf)
        {
            try
            {
                if (uf != null)
                {
                    if (uf.Id == 0)
                    {
                        _context.UF.Add(uf);
                    }
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public UF RecuperarUFId(int id)
        {
            return _context.UF.Find(id);
        }

        public IQueryable<UF> RecuperarUF()
        {
            return _context.UF.Select(c => new UF
            {
                Id = c.Id,
                UFs = c.UFs,
            });
        }

        public void RemoverUF(UF uf)
        {
            try
            {
                if(uf != null)
                {
                    if(uf.Id != 0)
                    {
                        _context.UF.Remove(uf);
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
