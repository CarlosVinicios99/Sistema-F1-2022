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
            //adicionar os pontos para os 10 primeiros
        }

        public void PontuarMelhorVolta(List<Piloto> pilotos, string nomePiloto)
        {
            //adicionar o ponto de melhor volta
        }

        public void ContabilizarVitoria(List<Piloto> pilotos)
        {
            //aumentar o numero de vitorias do vencedor da corrida
        }
        
        public void ContabilizarPodios(List<Piloto> pilotos)
        {
            //aumentar podio dos 3 primeiros
        }
    }
}