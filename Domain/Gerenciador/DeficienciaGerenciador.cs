using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Gerenciador
{
    class DeficienciaGerenciador : GerenciadorBase
    {
        public DeficienciaGerenciador()
        {
            _context = new Context.SiteContext();
        }

        public void AdicionarDeficiencia(Deficiencia deficiencia)
        {
            try
            {
                if (deficiencia != null)
                {
                    if (deficiencia.Id == 0)
                    {
                        _context.Deficiencia.Add(deficiencia);
                    }
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Deficiencia RecuperarDeficienciaId(int id)
        {
            return _context.Deficiencia.Find(id);
        }

        public IQueryable<Deficiencia> RecuperarDeficiencia()
        {
            return _context.Deficiencia.Select(c => new Deficiencia
            {
                Id = c.Id,
                Tipo = c.Tipo,
            });
        }

        public void ApagarDeficiencia(Deficiencia deficiencia)
        {
            try
            {
                if(deficiencia != null)
                {
                    _context.Deficiencia.Remove(deficiencia);
                    _context.SaveChanges();
                }



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
