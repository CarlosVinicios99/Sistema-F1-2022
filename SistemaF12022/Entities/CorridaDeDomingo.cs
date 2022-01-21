using System;

namespace SistemaF12022.Entities
{
    class CorridaDeDomingo : Corrida
    {
        public CorridaDeDomingo(string local) 
        : base(local)
        {
            
        }
        public override void DistribuirPontos()
        {
            Console.WriteLine("f");
        }

        public void PontuarMelhorVolta(Piloto piloto)
        {
            //usar o list find encontrar o piloto e dar o ponto
        }

        public void ContabilizarVitoria()
        {
            //aumentar o numero de vitoria
        }
        
        public void ContabilizarPodios()
        {
            //aumentar podio dos 3 primeiros
        }
    }
}