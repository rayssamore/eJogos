using EJOGOSS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOSS.Controllers
{
    public class EquipeController : Controller
    {
        //IActionResult representam os varios código HTTP

        Equipe equipeModel = new Equipe();
 
        public IActionResult Index()
        {
            ViewBag.Equipes = equipeModel.LerEquipes();

            return View();
        }
    }
}
