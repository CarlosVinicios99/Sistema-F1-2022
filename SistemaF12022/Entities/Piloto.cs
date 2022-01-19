using System;
using System.Text;

namespace SistemaF12022.Entities
{
    class Piloto : IComparable
    {
        public string Nome {get; set;}
        public int Numero {get; set;}
        public int Pontos {get; private set;}
        public int Vitorias {get; private set;}
        public int Podios {get; private set;}
        public Equipe Equipe {get; set;}

        public Piloto()
        {

        }

        public Piloto(string nome, int numero, int pontos, int vitorias, int podios, Equipe equipe)
        {
            Nome = nome;
            Numero = numero;
            Pontos = pontos;
            Vitorias = vitorias;
            Podios = podios;
            Equipe = equipe;
        }

        public void AtualizarPontuacao(int pontosGanhos)
        {
            Pontos += pontosGanhos;
        }

        public void AtualizarVitorias()
        {
            Vitorias++;
        }

        public void AtualizarPodios()
        {
            Podios++;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome);
            sb.Append(" ");
            sb.Append(Pontos);
            sb.Append(" pontos, ");
            sb.Append(Vitorias);
            sb.Append(" vitorias, ");
            sb.Append(Podios);
            sb.AppendLine(" podios");

            return sb.ToString();
        }

        public int CompareTo(Object obj)
        {
            if(!(obj is Piloto))
            {
                throw new ArgumentException("Comparing error: O argumento utilizado nao eh um objeto piloto");
            }

            Piloto piloto = (Piloto) obj;
            return Pontos.CompareTo(piloto.Pontos);
        }
    }
}