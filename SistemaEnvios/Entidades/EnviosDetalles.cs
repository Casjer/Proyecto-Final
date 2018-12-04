using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SistemaEnvios.Entidades
{
    public class EnviosDetalles
    {
        [Key]
        public int ID { get; set; }
        public int EnviosID { get; set; }
        public int UsuarioID { get; set; }
        public int MonedasID { get; set; }
        public int Cantidad { get; set; }
        public int Importe { get; set; }
        public string Monedas { get; set; }
        public int ClientesID { get; set; }

        [ForeignKey("MonedasID")]
        public virtual Monedas Moneda { get; set; }

        public EnviosDetalles()
        {
            ID = 0;
            EnviosID = 0;
        }

        public EnviosDetalles(int id,int enviosid,int usuarioid,int monedasid,int cantidad,int importe, string monedas,int clientesid)
        {
            ID = id;
            EnviosID = enviosid;
            UsuarioID = usuarioid;
            MonedasID = monedasid;
            Cantidad = cantidad;
            Importe = importe;
            Monedas = monedas;
            ClientesID = clientesid;

        }

    }
}
