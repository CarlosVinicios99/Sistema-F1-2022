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
            for(int i = 0; i < 3; i++)
            {
                pilotos.Find(p => p.Nome.ToUpper().Equals(GridFinal[i].ToUpper())).AtualizarPontuacao(3 - i);
            }
        }
    }
}