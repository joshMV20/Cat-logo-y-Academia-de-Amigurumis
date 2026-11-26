using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatálogoAcademiaDeAmigurumis.Abstracciones.Modelos.Inscripcion
{
    public class InscripcionACursoDto
    {
        public int IdInscripcion { get; set; }

        [Display(Name = "Id Curso", Prompt = "Ingrese el id del curso", Description = "Id Curso")]
        public int IdCurso { get; set; }

        [Display(Name = "Id Estudiante", Prompt = "Ingrese el id del estudiante", Description = "Id Estudiante")]
        public int IdEstudiante { get; set; }

        public DateTime FechaSolicitud { get; set; }

        public string Estado { get; set; }
    }
}
