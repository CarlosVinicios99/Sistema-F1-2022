using System;
using System.Text;

namespace SistemaF12022.Entities
{
    class Equipe : IComparable
    {
        public string Nome {get; set;}
        public int Pontos {get; private set;}
        public Piloto[] Pilotos {get; set;}

        public Equipe()
        {

        }

        public Equipe(string nome, int pontos, Piloto piloto1, Piloto piloto2)
        {
            Pilotos = new Piloto[2];
            Pilotos[0] = piloto1;
            Pilotos[1] = piloto2;

            Nome = nome;
            Pontos = pontos;
        }

        public void AtualizarPontuacao(int pontos)
        {
            Pontos += pontos;
        }

        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
           sb.Append(Nome);
           sb.Append(" ");
           sb.Append(Pontos);
           sb.Append(" pontos"); 

           return sb.ToString();
        }

        public int CompareTo(Object obj)
        {
            if(!(obj is Equipe))
            {
                throw new ArgumentException("Comparing error: O Argumento nao eh um objeto equipe");
            }

            Equipe equipe = (Equipe) obj;
            return equipe.Pontos.CompareTo(Pontos);
        }
    }
}