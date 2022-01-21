using System.Collections.Generic;

namespace SistemaF12022.Entities
{
    abstract class Corrida
    {
        public string Local {get; set;}
        protected List<Piloto> GridFinal;

        public Corrida()
        {
            
        }

        public Corrida(string local)
        {
            Local = local;
            GridFinal = new List<Piloto>();
        }

        public void adicionarAoGridFinal(Piloto piloto)
        {
            GridFinal.Add(piloto);
        }
        public abstract void DistribuirPontos();
    }
}