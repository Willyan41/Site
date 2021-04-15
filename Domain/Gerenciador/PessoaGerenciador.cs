using Domain.Entidades;
using Domain.Regras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Gerenciador
{
    class PessoaGerenciador : GerenciadorBase
    {
        public PessoaGerenciador()
        {
            _context = new Context.SiteContext();
        }

        public void AdicionarPessoa(Pessoa pessoa)
        {
            try
            {
                if (pessoa != null)
                {
                    if (pessoa.Id == 0)
                    {
                        if (CPFRegra.ValidarCPF(pessoa.CPF))
                        {
                            _context.Pessoa.Add(pessoa);
                        }
                    }
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Pessoa RecuperarPessoaId(int id)
        {
            return _context.Pessoa.Find(id);
        }

        public IQueryable<Pessoa> RecuperarPessoa()
        {
            return _context.Pessoa.Select(c => new Pessoa
            {
                Id = c.Id,
                Contato = c.Contato,
                CPF = c.CPF,
                EstadoCivil = c.EstadoCivil,
                DataNascimento = c.DataNascimento,
                Deficiencia = c.Deficiencia,
                Naturalidade = c.Naturalidade,
                Nome = c.Nome,
                Residencia = c.Residencia,
                Sexo = c.Sexo,
                TipoSanguineo = c.TipoSanguineo,

            });
        }

        public void RemoverPessoa(Pessoa pessoa)
        {
            try
            {
                if (pessoa != null)
                {
                    if (pessoa.Id != 0)
                    {
                        _context.Pessoa.Remove(pessoa);
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
