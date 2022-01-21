using System.Collections.Generic;

namespace SistemaF12022.Entities
{
    class CorridaSprint : Corrida
    {

        public CorridaSprint()
        {

        }

        public CorridaSprint(string local)
        : base(local)
        {

        }
        
        public override void DistribuirPontos(List<Piloto> pilotos)
        {
            //distribuir pontos para os 3 primeiros
        }
    }
}