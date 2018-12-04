using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaEnvios.Entidades
{
   public class Usuarios
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public Usuarios()
        {
            UsuarioID = 0;
            Nombre = string.Empty;
            NombreUsuario = string.Empty;
            Contrasena = string.Empty;
        }
    }
}
