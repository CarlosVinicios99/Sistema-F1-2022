using System;
using System.Collections.Generic;

using SistemaF12022.Repositories;

namespace SistemaF12022.Entities
{
    class Temporada
    {
        private List<Equipe> _equipes = new List<Equipe>();
        private List<Piloto> _pilotos = new List<Piloto>();
        private Corrida _novaCorrida;

        public Temporada()
        {
            _equipes = ManipulaDados.CarregarDadosTemporada();
            InicializarPilotos();
        }

        private void InicializarPilotos()
        {
            foreach(Equipe equipe in _equipes)
            {
                _pilotos.Add(equipe.Pilotos[0]);
                _pilotos.Add(equipe.Pilotos[1]);
            }
        } 

        public void ExibirClassificacaoMundialDePilotos()
        {
            _pilotos.Sort();
            foreach(Piloto piloto in _pilotos)
            {
                Console.WriteLine(piloto);
            }
        }

        public void ExibirClassificacaoMundialDeEquipes()
        {
            _equipes.Sort();
            foreach(Equipe equipe in _equipes)
            {
                Console.WriteLine(equipe);
            }
        }
        
        //metodo para criar nova corrida
    }
}