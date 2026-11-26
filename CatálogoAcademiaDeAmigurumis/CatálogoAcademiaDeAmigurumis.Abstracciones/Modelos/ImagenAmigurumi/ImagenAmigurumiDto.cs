using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatálogoAcademiaDeAmigurumis.Abstracciones.Modelos.ImagenAmigurumi
{
    internal class ImagenAmigurumiDto
    {
        public int IdImagen { get; set; }

        public int IdAmigurumi { get; set; }

        public string RutaImagen { get; set; }
    }
}
