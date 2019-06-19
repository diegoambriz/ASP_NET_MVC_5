using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//Acceder a funciones de Entity Framewrork
using System.ComponentModel.DataAnnotations;//Agregar atributos

namespace App_ASP_NET_MVC_5.Models
{
    public class Contacto
    {
        public string Nombre { get; set; }
        [Key]
        public string Email { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
    }

    public class ContactoContext : DbContext
    {
        public DbSet<Contacto> Contactos { get; set; }
    }
}