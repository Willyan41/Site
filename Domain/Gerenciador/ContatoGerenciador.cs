using Domain.Context;
using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Gerenciador
{
    class ContatoGerenciador : GerenciadorBase
    {
        public ContatoGerenciador()
        {
            _context = new SiteContext();
        }

        public void AdicionarContato(Contato contato)
        {
            try
            {
                if (contato != null)
                {
                    if (contato.Id == 0)
                    {
                        _context.Contato.Add(contato);
                    }
                    _context.SaveChanges();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Contato RecuperarPorId(int id)
        {
            return _context.Contato.Find(id);
        }

        public IQueryable<Contato> RecuperarContato()
        {
            return _context.Contato.Select(c => new Contato
            {
                Id = c.Id,
                TelFixo = c.TelFixo,
                TelCel = c.TelCel,
                Email = c.Email,
            });
        }

        public void ApagarContato(Contato contato)
        {
            try
            {
                if(contato != null)
                {
                    _context.Contato.Remove(contato);
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
