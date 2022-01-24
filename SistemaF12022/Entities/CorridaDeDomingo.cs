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
            pilotos.Find(p => p.Nome.ToUpper().Equals(nomePiloto.ToUpper())).AtualizarPontuacao(1);
        }

        public void ContabilizarVitoria(List<Piloto> pilotos)
        {
            //
        }
        
        public void ContabilizarPodios(List<Piloto> pilotos)
        {
            //aumentar podio dos 3 primeiros
        }
    }
}