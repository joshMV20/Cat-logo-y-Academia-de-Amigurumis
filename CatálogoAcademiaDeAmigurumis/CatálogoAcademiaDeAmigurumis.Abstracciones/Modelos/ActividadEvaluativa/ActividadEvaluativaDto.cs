using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatálogoAcademiaDeAmigurumis.Abstracciones.Modelos.ActividadEvaluativa
{
    public class ActividadEvaluativaDto
    {
        public int IdActividad { get; set; }

        public int IdCurso { get; set; }

        [Display(Name = "Nombre", Prompt = "Ingrese el nombre", Description = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción", Prompt = "Ingrese la descripción", Description = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Fecha de Entrega", Prompt = "Ingrese la fecha de entrega", Description = "Fecha de Entrega")]
        public DateTime FechaEntrega { get; set; }

        [Display(Name = "Puntaje Máximo", Prompt = "Ingrese el puntaje máximo", Description = "Puntaje Máximo")]
        public decimal PuntajeMaximo { get; set; }

        [Display(Name = "Tipo de Actividad", Prompt = "Ingrese el tipo de actividad", Description = "Tipo de Actividad")]
        public string TipoActividad { get; set; }
    }
}
