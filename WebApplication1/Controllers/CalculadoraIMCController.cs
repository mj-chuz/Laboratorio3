using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3.Models;

namespace Laboratorio3.Controllers
{
    public class CalculadoraIMCController : Controller
    {
        public ActionResult ResultadoIMC()
        {
            PersonaModel persona = new PersonaModel(1, "Cristiano Ronaldo", 84.0, 1.87);
            double IMC = persona.Peso / (persona.Estatura * persona.Estatura);
            ViewBag.IMC = IMC;
            ViewBag.persona = persona;
            return View();
        }

        public ActionResult ResultadosAleatoriosIMC()
        {
            Random random = new Random();
            PersonaModel[] personas = new PersonaModel[30];
            double[] IMCs = new double[30];
            double pesoAleatorio = 0.0;
            double estaturaAleatoria = 0.0;
            PersonaModel persona;
            double IMC = 0.0;
            

            for (int idPersonas = 0; idPersonas < 30; idPersonas++)
            {
                pesoAleatorio = random.NextDouble() * (150 - 20) + 20;
                estaturaAleatoria = random.NextDouble() * (2 - 1) + 1;
                persona = new PersonaModel(idPersonas, "Sin nombre", pesoAleatorio, estaturaAleatoria);
                IMC = persona.Peso / (persona.Estatura * persona.Estatura);
                personas[idPersonas] = persona;
                IMCs[idPersonas] = IMC;
            }

            ViewBag.IMCs = IMCs;
            ViewBag.personas = personas;
            return View();
        }
    }
}