using Projeto.NAC.Fiap.Models;
using Projeto.NAC.Fiap.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.NAC.Fiap.Controllers
{
    public class VendaController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpPost]
        public ActionResult Pagar(int codigo)
        {
            var venda = _unit.VendaRepository.BuscarPor(v => v.VendaId == codigo)[0];
            venda.Pago = true;
            _unit.VendaRepository.Atualizar(venda);
            _unit.Salvar();
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Buscar(bool pago)
        {
            var lista = _unit.VendaRepository.BuscarPor(v => v.Pago == pago);
            return View("Listar", lista);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.VendaRepository.Listar());
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Venda venda)
        {
            _unit.VendaRepository.Cadastrar(venda);
            _unit.Salvar();
            TempData["msg"] = "Cadastrardo";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}