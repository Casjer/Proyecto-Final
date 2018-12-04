using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaEnvios.Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteID { get; set; }
        public string Nombres { get; set; }
        public string Identidad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }



        public Clientes()
        {
            ClienteID = 0;
            Nombres = string.Empty;
            Identidad = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
        }
    }
}
