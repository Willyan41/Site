using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Gerenciador
{
    class TipoSanguineoGerenciador : GerenciadorBase
    {
        public TipoSanguineoGerenciador()
        {
            _context = new Context.SiteContext();
        }

        public void AdicionarTipoSanguineo(TipoSanguineo tipoSanguineo)
        {
            try
            {
                if (tipoSanguineo != null)
                {
                    if (tipoSanguineo.Id == 0)
                    {
                        _context.TipoSanguineo.Add(tipoSanguineo);
                    }
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TipoSanguineo RecuperarTipoSanguineoId(int id)
        {
            return _context.TipoSanguineo.Find(id);
        }

        public IQueryable<TipoSanguineo> RecuperarTipoSanguineo()
        {
            return _context.TipoSanguineo.Select(c => new TipoSanguineo
            {
                Id = c.Id,
                Tipo = c.Tipo,
                FatorRh = c.FatorRh,
            });
        }

        public void RemoverTipoSanguineo(TipoSanguineo tipoSanguineo)
        {
            try
            {
                if(tipoSanguineo != null)
                {
                    if(tipoSanguineo.Id != 0)
                    {
                        _context.TipoSanguineo.Remove(tipoSanguineo);
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
