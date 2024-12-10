using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAplicacaoWeb.Models.Carros;

namespace MinhaPrimeiraAplicacaoWeb.Controllers
{
    public class CarrosController : Controller
    {

        public List<CarroModel> _Carros = new List<CarroModel>()
        {

                new CarroModel() { Codigo = 1, Modelo = "Palio", Placa = "MDW-0791", Ano = 2024 },
                new CarroModel() { Codigo = 2, Modelo = "Corolla", Placa = "MCK-0623", Ano = 2024 },
                new CarroModel() { Codigo = 3, Modelo = "Subaru", Placa = "MBE-2023", Ano = 2024 },
                new CarroModel() { Codigo = 4, Modelo = "Vectra", Placa = "MJO-0377", Ano =2020 },
                new CarroModel() { Codigo = 5, Modelo = "Civic", Placa = "MJC-3314", Ano = 2024 }
        };
        public IActionResult Index()
        {

            var model = new CarrosModel() { Carros = _Carros };
            return View(model);
        }

        public IActionResult Record(long id)
        {
            var carro = _Carros.FirstOrDefault(x => x.Codigo == id);
            return View(carro);
        }
    }
}
