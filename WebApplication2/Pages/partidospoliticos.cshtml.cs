using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.models;

namespace WebApplication2.Pages
{
    public class partidospoliticosModel : PageModel
    {

        public List<partidosPoliticos> partidospoliticos { get; set; }
        public void OnGet()
        {

            partidospoliticos = new List<partidosPoliticos>
            {

                new partidosPoliticos()
                {
                    Nombre = "Partido Popular",
                    Siglas = "PP",
                    Descripcion="corrupcion",
                    Posicion = "centro-derecha",
                    Votantes = "5.000.000"
                },

                new partidosPoliticos()
                {
                    Nombre = "Partido Socialista Obrero Español",
                    Siglas = "PSOE",
                    Descripcion="Partido para tontos",
                    Posicion = "centro-izquierda",
                    Votantes = "6.700.000"
                },

                new partidosPoliticos()
                {
                    Nombre = "VOX",
                    Siglas = "VOX",
                    Descripcion="TOP",
                    Posicion = "derecha",
                    Votantes = "3.600.000"
                }

            };

        }
    }
}