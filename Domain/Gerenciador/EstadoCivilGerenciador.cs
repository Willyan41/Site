using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Gerenciador
{
    class EstadoCivilGerenciador : GerenciadorBase
    {
        public EstadoCivilGerenciador()
        {
            _context = new Context.SiteContext();
        }

        public void AdicionarEstadoCivil(EstadoCivil estadoCivil)
        {
            try
            {
                if(estadoCivil != null)
                {
                    if(estadoCivil.Id == 0)
                    {
                        _context.EstadoCivil.Add(estadoCivil);
                    }
                    _context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EstadoCivil RecuperarEstadoCivilId(int id)
        {
            return _context.EstadoCivil.Find(id);
        }

        public IQueryable<EstadoCivil> RecuperarEstadoCivil()
        {
            return _context.EstadoCivil.Select(c => new EstadoCivil
            {
                Id = c.Id,
                EstadosCivis = c.EstadosCivis,

            });
                       
        }

        public void ApagarEstadoCivil(EstadoCivil estadoCivil)
        {
            try
            {
                if(estadoCivil != null)
                {
                    if(estadoCivil.Id != 0)
                    {
                        _context.EstadoCivil.Remove(estadoCivil);
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
