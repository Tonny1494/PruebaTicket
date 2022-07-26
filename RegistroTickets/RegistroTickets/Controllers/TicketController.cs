using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroTickets.Controllers
{
    
    public class TicketController : Controller
    {
        // GET: Ticket
        private Ticket tick =new Ticket();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.alerta = "info";
            ViewBag.res = "Registrar Ticket";
            return View(tick.listarTickets());
        }
        [HttpPost]
        public ActionResult Index(String personaSoli, String asunto, String descripInci, DateTime fecha)
        {
            if (tick.InsertarTicket(personaSoli, asunto, descripInci, fecha))
            {
                ViewBag.alerta = "success";
                ViewBag.res = "Ticket Registrado Correctamente";
            }
            else
            {
                ViewBag.alerta = "danger";
                ViewBag.res = "Ticket No Registrado ";
            }
            return View(tick.listarTickets());


        }

        }
}