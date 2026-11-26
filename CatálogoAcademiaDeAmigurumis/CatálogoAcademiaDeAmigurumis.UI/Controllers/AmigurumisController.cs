using CatálogoAcademiaDeAmigurumis.Abstracciones.Modelos.Amigurumi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatálogoAcademiaDeAmigurumis.UI.Controllers
{
    public class AmigurumisController : Controller
    {
        // GET: Amigurumis
        public ActionResult ObtenerLaListaDeAmigurumis()
        {
            var lista = new List<AmigurumiDto>()
    {
        new AmigurumiDto()
        {
            IdAmigurumi = 1,
            Nombre = "Conejo Rosa",
            Descripcion = "Tejido a mano",
            Tamano = "30 cm",
            Tecnica = "Crochet",
            Precio = 12000,
            Estado = "Disponible",
            ImagenPrincipal = "https://via.placeholder.com/300x250"
        },

        new AmigurumiDto()
        {
            IdAmigurumi = 2,
            Nombre = "Oso Panda",
            Descripcion = "Hecho en algodón",
            Tamano = "25 cm",
            Tecnica = "Amigurumi",
            Precio = 18000,
            Estado = "Agotado",
            ImagenPrincipal = "https://via.placeholder.com/300x250"
        }
    };

            return View(lista);
        }

        // GET: Amigurumis/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Amigurumis/Create
        public ActionResult AgregarAmigurumi()
        {
            return View();
        }

        // POST: Amigurumis/Create
        [HttpPost]
        public ActionResult AgregarAmigurumi(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Amigurumis/Edit/5
        public ActionResult EditarAmigurumi(int id)
        {
            var ejemplo = new AmigurumiDto
            {
                IdAmigurumi = 1,
                Nombre = "Oso Tejido",
                Descripcion = "Producto de demostración",
                Tamano = "25 cm",
                Tecnica = "Crochet",
                Precio = 15000,
                Estado = "Disponible",
                ImagenPrincipal = "~/Imagenes/OsoKroche.jpg"
            };

            return View(ejemplo);
        }

        // POST: Amigurumis/Edit/5
        [HttpPost]
        public ActionResult EditarAmigurumi(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Amigurumis/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Amigurumis/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
