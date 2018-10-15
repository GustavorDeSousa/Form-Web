using Projeto.NAC.Fiap.Models;
using Projeto.NAC.Fiap.Persistencia;
using Projeto.NAC.Fiap.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Projeto.NAC.Fiap.Repository
{
    public class VendaRepository : IVendaRepository
    {
        private LojaContext _context;

        public VendaRepository(LojaContext context)
        {
            _context = context;
        }

        public void Atualizar(Venda venda)
        {
            _context.Entry(venda).State = EntityState.Modified;
        }

        public IList<Venda> BuscarPor(Expression<Func<Venda, bool>> filtro)
        {
            return _context.Vendas.Where(filtro).ToList();
        }

        public void Cadastrar(Venda venda)
        {
            _context.Vendas.Add(venda);
        }

        public IList<Venda> Listar()
        {
            return _context.Vendas.ToList();
        }
    }
}