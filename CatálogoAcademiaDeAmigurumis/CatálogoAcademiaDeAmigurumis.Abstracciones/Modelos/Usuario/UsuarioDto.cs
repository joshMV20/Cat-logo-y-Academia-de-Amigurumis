using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatálogoAcademiaDeAmigurumis.Abstracciones.Modelos.Usuario
{
    public class UsuarioDto
    {
        public int IdUsuario { get; set; }

        [Display(Name = "Nombre", Prompt = "Ingrese el nombre", Description = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Primer Apellido", Prompt = "Ingrese el primer apellido", Description = "Primer Apellido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido", Prompt = "Ingrese el segundo apellido", Description = "Segundo Apellido")]
        public string SegundoApellido { get; set; }
        
        [Display(Name = "Correo", Prompt = "Ingrese el correo", Description = "Correo")]
        public string Correo { get; set; }

        [Display(Name = "Teléfono", Prompt = "Ingrese el teléfono", Description = "Teléfono")]
        public string Telefono { get; set; }

        public string Rol { get; set; }

        public string Estado { get; set; }
    }
}
