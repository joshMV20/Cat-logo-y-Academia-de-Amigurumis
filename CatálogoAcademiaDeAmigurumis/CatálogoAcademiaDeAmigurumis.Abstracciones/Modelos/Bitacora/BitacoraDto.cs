using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatálogoAcademiaDeAmigurumis.Abstracciones.Modelos.Bitacora
{
    public class BitacoraDto
    {
        public int IdEvento { get; set; }

        [Display(Name = "Fecha del Evento", Prompt = "Ingrese la fecha del evento", Description = "Fecha del Evento")]
        public DateTime FechaEvento { get; set; }

        public int IdUsuario { get; set; }

        [Display(Name = "Tipo de Evento", Prompt = "Ingrese el tipo de evento", Description = "Tipo de Evento")]
        public string TipoEvento { get; set; }

        public string Descripcion { get; set; }
    }
}
