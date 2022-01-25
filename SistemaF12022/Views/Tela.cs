using System;
using SistemaF12022.Entities;
namespace SistemaF12022.Views
{
    class Tela
    {
        private Temporada _temporada = new Temporada();
        public Tela()
        {
            cicloDoSistema();
        }

        private void cicloDoSistema()
        {
            int opcao = 0;
            while(opcao != 5)
            {
                Console.WriteLine("(1)Classificacao do mundial de pilotos");
                Console.WriteLine("(2)Classificacao do mundial de equipes");
                Console.WriteLine("(3)Inserir resultado de uma corrida");
                Console.WriteLine("(4)Fim da temporada");
                Console.WriteLine("(5)Sair");

                opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch(opcao)
                {
                    case 1:
                        _temporada.ExibirClassificacaoMundialDePilotos();
                        break;

                    case 2:
                        _temporada.ExibirClassificacaoMundialDeEquipes();
                        break;

                    case 3:
                        Console.WriteLine("(1)Corrida De Domingo\n(2)Corrida Sprint");
                        int tipoDeCorrida = int.Parse(Console.ReadLine());
                        
                        Console.Write("Digite o pais da corrida: ");
                        string local = Console.ReadLine();

                        string[] nomes = DefinirGrid();

                        Console.Write("Digite o nome do piloto com a volta mais rapida: ");
                        if(tipoDeCorrida == 1)
                        {
                            string pilotoVoltaMaisRapida = Console.ReadLine();
                            _temporada.CriarCorrida(tipoDeCorrida, local, nomes, pilotoVoltaMaisRapida);
                        }

                        else
                        {
                            _temporada.CriarCorrida(tipoDeCorrida, local, nomes, "");
                        }
                        break;

                    case 4:
                        _temporada.ExibirClassificacaoMundialDePilotos();
                        _temporada.ExibirClassificacaoMundialDeEquipes();
                        break;

                    case 5:
                        Console.WriteLine("Encerrando...");
                        break;

                    default:
                        Console.WriteLine("OPCAO INVALIDA!/nTENTE NOVAMENTE");
                        break;
                }
                Console.WriteLine();
            }
        }

        private string[] DefinirGrid()
        {
            string[] grid = new string[20];             //20 = numero de pilotos na temporada

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("(33)Max Verstappen\n(11)Sergio Perez");
                Console.WriteLine("(44)Lewis Hamilton\n(63)George Russell");
                Console.WriteLine("(16)Charles Leclerc\n(55)Carlos Sainz");
                Console.WriteLine("(4)Lando Norris\n(3)Daniel Ricciardo");
                Console.WriteLine("(14)Fernando Alonso\n(31)Esteban Ocon");
                Console.WriteLine("(10)Pierre Gasly\n(22)Yuki Tsunoda");
                Console.WriteLine("(18)Lance Stroll\n(5)Sebastian Vettel");
                Console.WriteLine("(6)Nicholas Latifi\n(70)Alex Albon");
                Console.WriteLine("(77)Valtteri Bottas\n(80)Guanyu Zhou");
                Console.WriteLine("(47)Mick Schumacher\n(9)Nikita Mazepin\n");

                Console.Write("P" + (i + 1) + ": ");
                int numero = int.Parse(Console.ReadLine());

                grid[i] =_temporada.Pilotos.Find(p => p.Numero == numero).Nome;
                Console.Clear();
            }
            return grid;
        }
    }
}