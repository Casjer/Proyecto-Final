using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaEnvios.Entidades
{
   public class EntradaMonedas
    {
        [Key]
        public int EntradaID { get; set; }
        public DateTime Fecha { get; set; }
        public int MonedasID { get; set; }
        public int Cantidad { get; set; }

        public EntradaMonedas()
        {
            EntradaID = 0;
            Fecha = DateTime.Now;
            MonedasID = 0;
            Cantidad = 0;
        }
    }
}
