using System;

namespace SistemaF12022.Views
{
    class Tela
    {
        //declarar um objeto controlador para indicar as operacoes
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
                        //carregar a classificacao do mundial de pilotos e mostrar
                        //se nao tiver ocorrido nenhuma corrida mostrar tudo zerado
                        break;

                    case 2:
                        //carregar a classificacao do mundial de equipes e mostrar
                        //se nao tiver ocorrido nenhuma corrida mostrar tudo zerado
                        break;

                    case 3:
                        //deve informar se a corrida eh sprint ou de domingo
                        //em seguida a corrida deve ser criada e os dados inseridos
                        //apos inserir os dados a pontuacao deve ser atualizada
                        break;

                    case 4:
                        //fim da temporada, todos os dados sobre pilotos e equipes devem ser mostrados
                        break;

                    case 5:
                        //saindo do programa
                        break;

                    default:
                        Console.WriteLine("OPCAO INVALIDA!/nTENTE NOVAMENTE");
                        break;
                }
            }
        }
    }
}