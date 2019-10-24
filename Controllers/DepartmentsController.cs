using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Departamentos.Models;
namespace Departamentos.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departments> lista = new List<Departments>();
            lista.Add(new Departments { name = "Eletronicos", id = 1 });
            lista.Add(new Departments { name = "Móveis", id = 2 });  
            
            return View(lista);
        }
    }
}