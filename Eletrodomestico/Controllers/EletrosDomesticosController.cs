using Eletrodomestico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eletrodomestico.Controllers
{
    public class EletrosDomesticosController : Controller
    {
        public IActionResult Index()
        {
            List<EletroDomestico> Eletros = new List<EletroDomestico>
            {
                new Geladeira {Marca = "Eletrolux", Modelo = "Mega bomba", ConsumoEnergetico = 50.60, CapacidadeLitros = 400, TemFreezer = true},
                new TV {Marca = "Sansung", Modelo = "Tp500", ConsumoEnergetico = 70.5, Tamnho = 90, Smart = true},
                new TV {Marca = "LG", Modelo = "Lg4000", ConsumoEnergetico = 60.3, Tamnho = 52, Smart = false}
            };
            return View(Eletros);
        }
    }
}