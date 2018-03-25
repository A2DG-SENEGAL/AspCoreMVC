using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleApplication
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            var personne = new Personne { Nom = "A2DG" , Prenom = "Senegal" , Age = 1};

            return View(personne);
        }

       
    }
}
