using Projeto.NAC.Fiap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Projeto.NAC.Fiap.Repositorio
{
    public interface IVendaRepository
    {
        void Cadastrar(Venda venda);
        void Atualizar(Venda venda);
        IList<Venda> Listar();

        IList<Venda> BuscarPor(Expression<Func<Venda, bool>> filtro);

    }
}