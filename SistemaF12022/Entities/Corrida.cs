using System.Collections.Generic;

namespace SistemaF12022.Entities
{
    abstract class Corrida
    {
        public string Local {get; set;}
        protected List<string> GridFinal;

        public Corrida()
        {
            
        }

        public Corrida(string local)
        {
            Local = local;
            GridFinal = new List<string>();
        }

        public void adicionarAoGridFinal(string nomePiloto)
        {
            GridFinal.Add(nomePiloto);
        }
        public abstract void DistribuirPontos(List<Piloto> pilotos);
    }
}