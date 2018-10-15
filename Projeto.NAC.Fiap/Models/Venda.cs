using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.NAC.Fiap.Models
{
    public class Venda
    {
        [Key]
        public int VendaId { get; set; }
        public string Cliente { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public bool Pago { get; set; }
    }
}