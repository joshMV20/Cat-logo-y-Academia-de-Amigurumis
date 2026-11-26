using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatálogoAcademiaDeAmigurumis.Abstracciones.Modelos.Asistencia
{
    public class AsistenciaDto
    {
        public int IdAsistencia { get; set; }

        public int IdCurso { get; set; }

        public int IdEstudiante { get; set; }

        public DateTime FechaLeccion { get; set; }

        public string Estado { get; set; }
    }
}
