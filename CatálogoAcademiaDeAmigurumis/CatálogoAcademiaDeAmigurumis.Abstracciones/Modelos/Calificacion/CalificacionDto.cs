using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatálogoAcademiaDeAmigurumis.Abstracciones.Modelos.Calificacion
{
    public class CalificacionDto
    {
        public int IdCalificacion { get; set; }

        public int IdActividad { get; set; }

        public int IdEstudiante { get; set; }

        [Display(Name = "Nota Obtenida", Prompt = "Ingrese la nota obtenida", Description = "Nota Obtenida")]
        public decimal NotaObtenida { get; set; }

        [Display(Name = "Retroalimentación", Prompt = "Ingrese la retroalimentación", Description = "Retroalimentación")]
        public string Retroalimentacion { get; set; }
    }
}
