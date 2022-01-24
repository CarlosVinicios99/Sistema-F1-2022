using System;
using System.IO;
using System.Collections.Generic;

using SistemaF12022.Entities;

namespace SistemaF12022.Repositories
{
    class ManipulaDados
    {
        public static List<Equipe> CarregarDadosTemporada()
        {
            string path = "/home/carlos/Documentos/C#/Projetos/Sistema-F1-2022/SistemaF12022/Repositories/Arquivos/dadosTemporada.csv";

            List<Equipe> equipes = new List<Equipe>();
           
            if(File.Exists(path))
            {
                try
                {
                    using(StreamReader sr = File.OpenText(path))
                    {
                        while(!sr.EndOfStream)
                        {
                            string[] linha = sr.ReadLine().Split(',');
                            string nomeEquipe = linha[0];
                            
                            int numeroPiloto1 = int.Parse(linha[1]);
                            string nomePiloto1 = linha[2];
                            int pontosPiloto1 = int.Parse(linha[3]);
                            int vitoriasPiloto1 = int.Parse(linha[4]);
                            int podiosPiloto1 = int.Parse(linha[5]);

                            int numeroPiloto2 = int.Parse(linha[6]);
                            string nomePiloto2 = linha[7];
                            int pontosPiloto2 = int.Parse(linha[8]);
                            int vitoriasPiloto2 = int.Parse(linha[9]);
                            int podiosPiloto2 = int.Parse(linha[10]);

                            Piloto piloto1 = new Piloto(nomePiloto1, numeroPiloto1, pontosPiloto1, vitoriasPiloto1, podiosPiloto1);

                            Piloto piloto2 = new Piloto(nomePiloto2, numeroPiloto2, pontosPiloto2, vitoriasPiloto2, podiosPiloto2);

                            equipes.Add(new Equipe(nomeEquipe, 0, piloto1, piloto2));
                        }
                    }
                }
                catch(IOException e)
                {
                    Console.WriteLine("Erro na leitura do arquivo de dados da temporada: " + e.Message);
                }

                return equipes;
            }

            else
            {
                path = "/home/carlos/Documentos/C#/Projetos/Sistema-F1-2022/SistemaF12022/Repositories/Arquivos/dadosIniciais.csv";

                try
                {
                    using(StreamReader sr = File.OpenText(path))
                    {
                        while(!sr.EndOfStream)
                        {
                            string[] linha = sr.ReadLine().Split(',');
                            string nomeEquipe = linha[0];

                            int numeroPiloto1 = int.Parse(linha[1]);
                            string nomePiloto1 = linha[2];

                            int numeroPiloto2 = int.Parse(linha[3]);
                            string nomePiloto2 = linha[4];

                            Piloto piloto1 = new Piloto(nomePiloto1, numeroPiloto1, 0, 0, 0);
                            Piloto piloto2 = new Piloto(nomePiloto2, numeroPiloto2, 0, 0, 0);

                            equipes.Add(new Equipe(nomeEquipe, 0, piloto1, piloto2));
                        }
                    }
                }
                catch(IOException e)
                {
                    Console.WriteLine("Erro de leitura: problema ao ler arquivo inicial " + e.Message);
                }

                SalvarDadosTemporada(equipes);
                return equipes;
            }
        }

        public static void SalvarDadosTemporada(List<Equipe> equipes)
        {
            string path = "/home/carlos/Documentos/C#/Projetos/Sistema-F1-2022/SistemaF12022/Repositories/Arquivos/dadosTemporada.csv";

            try
            {
                using(StreamWriter sw = File.CreateText(path))
                {
                    foreach(Equipe equipe in equipes)
                    {
                        sw.Write(equipe.Nome + "," + equipe.Pilotos[0].Numero + ",");
                        sw.Write(equipe.Pilotos[0].Nome + "," + equipe.Pilotos[0].Pontos + ",");
                        sw.Write(equipe.Pilotos[0].Vitorias + "," + equipe.Pilotos[0].Podios + ",");
                        sw.Write(equipe.Pilotos[1].Numero + "," + equipe.Pilotos[1].Nome + ",");
                        sw.Write(equipe.Pilotos[1].Pontos + "," + equipe.Pilotos[1].Vitorias + ",");
                        sw.WriteLine(equipe.Pilotos[1].Podios);
                    }
                }
            }

            catch(IOException e)
            {
                Console.WriteLine("Erro de escrita: problema ao gravar dados " + e.Message);
            }
        }

    }
}