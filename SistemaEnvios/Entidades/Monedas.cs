using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaEnvios.Entidades
{
    public class Monedas
    {
        [Key]
        public int MonedasID { get; set; }
        public string TipoMonedas { get; set; }
        public decimal Inventario { get; set; }

        public Monedas()
        {
            MonedasID = 0;
            TipoMonedas = string.Empty;
            Inventario = 0;
        }

        public override string ToString()
        {
            return this.TipoMonedas;
        }
    }
}
