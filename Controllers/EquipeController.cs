using EJOGOSS.Models;
using Microsoft.AspNetCore.Http;
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

        public IActionResult Cadastrar (IFormCollection form)
        {
            //Criar um objeto equipe a partir do froentend
            // IFormCollection

            Equipe novaEquipe = new Equipe();
            novaEquipe.IdEquipe = int.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];
            novaEquipe.Imagem = form["Imagem"];

            // Chamar a função criar passando um objeto do tipo EQUIPE
            equipeModel.Criar(novaEquipe);
            ViewBag.Equipes = equipeModel.LerEquipes();

            return LocalRedirect("~/Equipe");
        }
    }
}
