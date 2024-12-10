using MinhaPrimeiraAplicacaoWeb.Models.Carros;

namespace MinhaPrimeiraAplicacaoWeb.Models.Carros
{
    public class CarrosModel
    {
        public List<CarroModel> Carros { get; set; }

        public CarrosModel()
        {
            Carros = new List<CarroModel>();
        }
    }
}