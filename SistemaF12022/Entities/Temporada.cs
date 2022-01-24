using System;
using System.Collections.Generic;

using SistemaF12022.Repositories;

namespace SistemaF12022.Entities
{
    class Temporada
    {
        private List<Equipe> _equipes = new List<Equipe>();
        private List<Piloto> _pilotos = new List<Piloto>();
        private List<Corrida> _corridas = new List<Corrida>();

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
        
        public void CriarCorrida(int tipoCorrida, string local, string[] nomes, string pilotoVoltaMaisRapida)
        {
            if(tipoCorrida == 1)
            {
                 CorridaDeDomingo corridaDeDomingo = new CorridaDeDomingo(local);

                foreach(string nome in nomes)
                {
                    corridaDeDomingo.adicionarAoGridFinal(nome);
                }

                _corridas.Add(corridaDeDomingo);

                corridaDeDomingo.DistribuirPontos(_pilotos);
                corridaDeDomingo.PontuarMelhorVolta(_pilotos, pilotoVoltaMaisRapida);
                corridaDeDomingo.ContabilizarVitoria(_pilotos);
                corridaDeDomingo.ContabilizarPodios(_pilotos);
            }

            else
            {
                CorridaSprint corridaSprint = new CorridaSprint(local);
                foreach(string nome in nomes)
                {
                    corridaSprint.adicionarAoGridFinal(nome);
                }

                _corridas.Add(corridaSprint);
                corridaSprint.DistribuirPontos(_pilotos);
            }

            foreach(Equipe equipe in _equipes)
            {
                equipe.AtualizarPontuacao();
            }

            ManipulaDados.SalvarDadosTemporada(_equipes);
        }
    }
}