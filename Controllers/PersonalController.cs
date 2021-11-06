using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstApplication.Models;

namespace firstApplication.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal = new Personal();
            personal.name = "Hector";
            personal.lastname = "Franco";
            personal.age = 18;
            personal.direccion = "hector.franc0@hotmail.com";
            personal.codigoEst = "SMIS092321";
            personal.telefono = 72090294;
            return View(personal);
        }
    }
}