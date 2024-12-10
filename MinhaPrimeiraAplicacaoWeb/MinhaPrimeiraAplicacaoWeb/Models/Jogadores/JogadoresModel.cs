using MinhaPrimeiraAplicacaoWeb.Models.Jogador;

namespace MinhaPrimeiraAplicacaoWeb.Models.Jogador
{
    public class JogadoresModel
    {
        public List<JogadorModel> Jogadores { get; set; }

        public JogadoresModel()
        {
            Jogadores = new List<JogadorModel>();
        }
    }
}