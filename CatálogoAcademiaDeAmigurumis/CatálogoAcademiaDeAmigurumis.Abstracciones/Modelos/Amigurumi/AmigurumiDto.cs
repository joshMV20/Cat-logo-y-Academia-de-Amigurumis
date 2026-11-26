using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatálogoAcademiaDeAmigurumis.Abstracciones.Modelos.Amigurumi
{
    public class AmigurumiDto
    {
        public int IdAmigurumi { get; set; }

        [Display(Name = "Nombre", Prompt = "Ingrese el nombre", Description = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción", Prompt = "Ingrese la descripción", Description = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Tamaño", Prompt = "Ingrese el tamaño", Description = "Tamaño")]
        public string Tamano { get; set; }

        [Display(Name = "Técnica", Prompt = "Ingrese la técnica", Description = "Técnica")]
        public string Tecnica { get; set; }

        [Display(Name = "Precio", Prompt = "Ingrese el precio", Description = "Precio")]
        public decimal Precio { get; set; }

        
        public string Estado { get; set; }

        [Display(Name = "Imagen Principal", Prompt = "Ingrese la imagen principal", Description = "Imagen Principal")]
        public string ImagenPrincipal { get; set; }
    }
}
