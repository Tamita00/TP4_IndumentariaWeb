using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
        return View("Index");
    }
    public IActionResult SeleccionarIndumentaria()
    {
        ViewBag.listaEquipos = Equipos.listaEquipos;
        ViewBag.listaRemeras = Equipos.listaRemeras;
        ViewBag.listaPantalones = Equipos.listaPantalones;
        ViewBag.listaMedias = Equipos.listaMedias;
        return View("SeleccionarIndumentaria");
    }

    public IActionResult GuardarIndumentaria (int Equipo, int Media, int Pantalon, int Remera){
        Indumentaria nuevoEquipoConjunto = new Indumentaria(Equipos.listaMedias[Media - 1], Equipos.listaPantalones[Pantalon - 1], Equipos.listaRemeras[Remera - 1]);
        if(Equipos.IngresarIndumentaria(Equipos.listaEquipos[Equipo - 1], nuevoEquipoConjunto) == false) ViewBag.MensajeError = "Hubo un error";
        return RedirectToAction("Index");
    }
}
