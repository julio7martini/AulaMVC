﻿using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAplicacaoWeb.Models.Jogador;

namespace MinhaPrimeiraAplicacaoWeb.Controllers
{
    public class JogadoresController : Controller
    {

        public List<JogadorModel> _Jogadores = new List<JogadorModel>()
        {

                new JogadorModel() { ID = 1, Nome = "Gabigol", Clube = "Flamengo", Posicao = "Atacante" , Idade = 29},
                new JogadorModel() { ID = 2, Nome = "Diego Alves", Clube = "Flamengo", Posicao = "Goleiro" , Idade = 38},
                new JogadorModel() { ID = 3, Nome = "Eder Militao", Clube = "Real Madrid", Posicao = "Zagueiro" , Idade = 27},
                new JogadorModel() { ID = 4, Nome = "Neymar", Clube = "Al Hilal", Posicao = "Ponta-Esquerda" , Idade = 31},
                new JogadorModel() { ID = 5, Nome = "Gerson", Clube = "Flamengo", Posicao = "Volante" , Idade = 28}
        };
        public IActionResult Index()
        {

            var model = new JogadoresModel() { Jogadores = _Jogadores };
            return View(model);
        }

        public IActionResult Record(long id)
        {
            var jogador = _Jogadores.FirstOrDefault(x => x.ID == id);
            return View(jogador);
        }
    }
}