using System;
using System.Collections.Generic;

namespace SistemaF12022.Entities
{
    class CorridaDeDomingo : Corrida
    {
        public CorridaDeDomingo(string local) 
        : base(local)
        {
            
        }
        public override void DistribuirPontos(List<Piloto> pilotos)
        {
            for(int i = 0; i < 10; i++)
            {
                switch(i)
                {
                    case 0:
                        pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[i].ToUpper())).AtualizarPontuacao(25);
                        break;

                    case 1:
                        pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[i].ToUpper())).AtualizarPontuacao(18);
                        break;

                    case 2:
                        pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[i].ToUpper())).AtualizarPontuacao(15);
                        break;

                    case 3:
                        pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[i].ToUpper())).AtualizarPontuacao(12);
                        break;

                    case 4:
                        pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[i].ToUpper())).AtualizarPontuacao(10);
                        break;

                    case 5:
                        pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[i].ToUpper())).AtualizarPontuacao(8);
                        break;

                    case 6:
                        pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[i].ToUpper())).AtualizarPontuacao(6);
                        break;

                    case 7:
                        pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[i].ToUpper())).AtualizarPontuacao(4);
                        break;

                    case 8:
                        pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[i].ToUpper())).AtualizarPontuacao(2);
                        break;

                    case 9:
                        pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[i].ToUpper())).AtualizarPontuacao(1);
                        break;
                }
            }
        }

        public void PontuarMelhorVolta(List<Piloto> pilotos, string nomePiloto)
        {
            pilotos.Find(p => p.Nome.ToUpper().Equals(nomePiloto.ToUpper())).AtualizarPontuacao(1);
        }

        public void ContabilizarVitoria(List<Piloto> pilotos)
        {
            pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[0].ToUpper())).AtualizarVitorias();
        }
        
        public void ContabilizarPodios(List<Piloto> pilotos)
        {
            for(int i = 0; i < 3; i++)
            {
                pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[i].ToUpper())).AtualizarPodios();
            }
        }
    }
}