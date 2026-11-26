using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatálogoAcademiaDeAmigurumis.Abstracciones.Modelos.Curso
{
    public class CursoDto
    {
        public int IdCurso { get; set; }

        [Display(Name = "Nombre", Prompt = "Ingrese el nombre", Description = "Nombre")]
        public string Nombre { get; set; }
        
        [Display(Name = "Descripción", Prompt = "Ingrese la descripción", Description = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Nivel", Prompt = "Ingrese el nivel", Description = "Nivel")]
        public string Nivel { get; set; }

        [Display(Name = "Modalidad", Prompt = "Ingrese la modalidad", Description = "Modalidad")]
        public string Modalidad { get; set; }

        [Display(Name = "Fecha de Inicio", Prompt = "Ingrese la fecha de inicio", Description = "Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }

        public String HoraInicio { get; set; }


        [Display(Name = "Cupo Máximo", Prompt = "Ingrese el cupo máximo", Description = "Cupo Máximo")]
        public int CupoMaximo { get; set; }

        [Display(Name = "Cupos Disponibles", Prompt = "Ingrese los cupos disponibles", Description = "Cupos Disponibles")]
        public int CuposDisponibles { get; set; }

        public string Estado { get; set; }

        [Display(Name = "Id Docente", Prompt = "Ingrese el id del docente", Description = "Id Docente")]
        public int IdDocente { get; set; }
    }
}
