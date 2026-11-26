using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatálogoAcademiaDeAmigurumis.Abstracciones.Modelos.MaterialEducativo
{
    public class MaterialEducativoDto
    {
        public int IdMaterial { get; set; }

        public int IdCurso { get; set; }

        public string Nombre { get; set; }

        public string Tipo { get; set; }

        [Display(Name = "Ruta del Archivo", Prompt = "Ingrese la ruta del archivo", Description = "Ruta del Archivo")]
        public string RutaArchivo { get; set; }

        public string UrlExterna { get; set; }

        public string Estado { get; set; }
    }
}
