using System;
using System.Collections.Generic;

using SistemaF12022.Repositories;

namespace SistemaF12022.Entities
{
    class Temporada
    {
        private List<Equipe> _equipes = new List<Equipe>();
        public List<Piloto> Pilotos {get; private set;} = new List<Piloto>();
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
                Pilotos.Add(equipe.Pilotos[0]);
                Pilotos.Add(equipe.Pilotos[1]);
            }
        } 

        public void ExibirClassificacaoMundialDePilotos()
        {
            Pilotos.Sort();
            foreach(Piloto piloto in Pilotos)
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

                corridaDeDomingo.DistribuirPontos(Pilotos);
                corridaDeDomingo.PontuarMelhorVolta(Pilotos, pilotoVoltaMaisRapida);
                corridaDeDomingo.ContabilizarVitoria(Pilotos);
                corridaDeDomingo.ContabilizarPodios(Pilotos);
            }

            else
            {
                CorridaSprint corridaSprint = new CorridaSprint(local);
                foreach(string nome in nomes)
                {
                    corridaSprint.adicionarAoGridFinal(nome);
                }

                _corridas.Add(corridaSprint);
                corridaSprint.DistribuirPontos(Pilotos);
            }

            foreach(Equipe equipe in _equipes)
            {
                int pontos = Pilotos.Find(p => p.Numero == equipe.Pilotos[0].Numero).Pontos;
                pontos += Pilotos.Find(p => p.Numero == equipe.Pilotos[1].Numero).Pontos;
                equipe.AtualizarPontuacao(pontos);
            }
            
            ManipulaDados.SalvarDadosTemporada(_equipes);
        }
    }
}