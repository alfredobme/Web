using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Password { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Perfil { get; set; }
    }
}