using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaEnvios.Entidades
{
    public class Envios
    {
        [Key]
        public int EnviosID { get; set; }
        public int MonedasID { get; set; }
        public int ClientesID { get; set; }
        public DateTime Fecha { get; set; }
        public string Autorizacion { get; set; }
        public string Beneficiario { get; set; }
        public string Ordenante { get; set; }
        public string Identidad { get; set; }
        public string TelefonoOrdenante { get; set; }
        public string PaisOrigen { get; set; }
        public string Cajero { get; set; }
        public decimal Efectivo { get; set; }

        public virtual ICollection<EnviosDetalles> Detalle { get; set; }

        public Envios()
        {
            this.Detalle = new List<EnviosDetalles>();

            EnviosID = 0;
            MonedasID = 0;
            ClientesID = 0;
            Fecha = DateTime.Now;
            Autorizacion = string.Empty;
            Beneficiario = string.Empty;
            Ordenante = string.Empty;
            Identidad = string.Empty;
            TelefonoOrdenante = string.Empty;
            PaisOrigen = string.Empty;
            Cajero = string.Empty;
            Efectivo = 0;

        }

        public void AgregarDetalle(int id, int enviosid, int usuarioid, int monedasid, int cantidad, string monedas,int importe, int clientesid)
        {
            this.Detalle.Add(new EnviosDetalles(id, enviosid, usuarioid, monedasid, cantidad, importe, monedas, clientesid));
        }

    }
}
