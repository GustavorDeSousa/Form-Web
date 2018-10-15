using Projeto.NAC.Fiap.Persistencia;
using Projeto.NAC.Fiap.Repositorio;
using Projeto.NAC.Fiap.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.NAC.Fiap.Unity
{
    public class UnitOfWork : IDisposable
    {
        private LojaContext _context = new LojaContext();

        private IVendaRepository _vendaRepository;

        public IVendaRepository VendaRepository
        {
            get
            {
                if (_vendaRepository == null)
                {
                _vendaRepository = new VendaRepository(_context);
                }
                return _vendaRepository;
            }
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}