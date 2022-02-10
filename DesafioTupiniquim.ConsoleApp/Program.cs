using System;
/**
 * - Area total do retangulo
 * - Coordenada X & Y limite
 * - Direção que o robo está
 * 
 * variaveis
 * areaLimiteRetangulo,  coordenadaAtual, coordenadaAcrescentar, direcaoInstrucoes
 */

namespace DesafioTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //area retangulo
            int tamanhoMinimoX = 0, tamanhoMinimoY = 0, tamanhoMaximoX, tamanhoMaximoY;
            
            //posicao dos robos
            int[] coordenadaAtualPrimeiroRobo = new int[2];
            int[] coordenadaAtualSegundoRobo = new int[2];

            string ladoAtualPrimeiroRobo, ladoAtualSegundoRobo, lerDadosTelaPrimeiroRobo, lerDadosTelaSegundoRobo;

            //entrada
            //area
            Console.Write("Informe o tamanho do area (retangulo) desejada: ");
            lerDadosTelaPrimeiroRobo = Console.ReadLine();
            tamanhoMaximoX = int.Parse(lerDadosTelaPrimeiroRobo[0].ToString());
            tamanhoMaximoY = int.Parse(lerDadosTelaPrimeiroRobo[1].ToString());

            //primeiro robô
            Console.Write("Informe a posição inicial do primeiro robô: ");
            lerDadosTelaPrimeiroRobo = Console.ReadLine();
            coordenadaAtualPrimeiroRobo[0] = int.Parse(lerDadosTelaPrimeiroRobo[0].ToString());
            coordenadaAtualPrimeiroRobo[1] = int.Parse(lerDadosTelaPrimeiroRobo[1].ToString());
            ladoAtualPrimeiroRobo = lerDadosTelaPrimeiroRobo[2].ToString();
            
            Console.Write("Informe a movimentação do primeiro robô: ");
            lerDadosTelaPrimeiroRobo = Console.ReadLine();
            
            //Segundo robô
            
            Console.Write("Informe a posição inicial do primeiro robô: ");
            lerDadosTelaSegundoRobo = Console.ReadLine();
            coordenadaAtualSegundoRobo[0] = int.Parse(lerDadosTelaSegundoRobo[0].ToString());
            coordenadaAtualSegundoRobo[1] = int.Parse(lerDadosTelaSegundoRobo[1].ToString());
            ladoAtualSegundoRobo = lerDadosTelaSegundoRobo[2].ToString();

            Console.Write("Informe a movimentação do primeiro robô: ");
            lerDadosTelaSegundoRobo = Console.ReadLine();

            //processamento
            //primeiro robo
            for (int i = 0; i < lerDadosTelaPrimeiroRobo.Length; i++)
            {
                if(lerDadosTelaPrimeiroRobo[i].ToString() == "e")
                {
                    switch (ladoAtualPrimeiroRobo)
                    {
                        case "n":
                            ladoAtualPrimeiroRobo = "o";
                            break;
                        case "o":
                            ladoAtualPrimeiroRobo = "s";
                            break;
                        case "s":
                            ladoAtualPrimeiroRobo = "l";
                            break;
                        case "l":
                            ladoAtualPrimeiroRobo = "n";
                            break;
                    }
                }
                else if (lerDadosTelaPrimeiroRobo[i].ToString() == "d")
                {
                    switch (ladoAtualPrimeiroRobo)
                    {
                        case "n":
                            ladoAtualPrimeiroRobo = "l";
                            break;
                        case "l":
                            ladoAtualPrimeiroRobo = "s";
                            break;
                        case "s":
                            ladoAtualPrimeiroRobo = "o";
                            break;
                        case "o":
                            ladoAtualPrimeiroRobo = "n";
                            break;
                    }
                }
                else if (lerDadosTelaPrimeiroRobo[i].ToString() == "m")//Avançar robô
                {
                    if (ladoAtualPrimeiroRobo == "n" && tamanhoMaximoY >= (coordenadaAtualPrimeiroRobo[1] + 1))
                    {
                        coordenadaAtualPrimeiroRobo[1] += 1;
                    }
                    else if (ladoAtualPrimeiroRobo == "o" && tamanhoMinimoX <= (coordenadaAtualPrimeiroRobo[0] - 1))
                    {
                        coordenadaAtualPrimeiroRobo[0] -= 1;
                    }
                    else if (ladoAtualPrimeiroRobo == "s" && tamanhoMinimoY <= (coordenadaAtualPrimeiroRobo[1] - 1))
                    {
                        coordenadaAtualPrimeiroRobo[1] -= 1;
                    }
                    else if (ladoAtualPrimeiroRobo == "l" && tamanhoMaximoX >= (coordenadaAtualPrimeiroRobo[0] + 1))
                    {
                        coordenadaAtualPrimeiroRobo[0] += 1;
                    }
                }
            }

            //segundo robô
            for (int i = 0; i < lerDadosTelaSegundoRobo.Length; i++)
            {
                if (lerDadosTelaSegundoRobo[i].ToString() == "e")
                {
                    switch (ladoAtualSegundoRobo)
                    {
                        case "n":
                            ladoAtualSegundoRobo = "o";
                            break;
                        case "o":
                            ladoAtualSegundoRobo = "s";
                            break;
                        case "s":
                            ladoAtualSegundoRobo = "l";
                            break;
                        case "l":
                            ladoAtualSegundoRobo = "n";
                            break;
                    }
                }
                else if (lerDadosTelaSegundoRobo[i].ToString() == "d")
                {
                    switch (ladoAtualSegundoRobo)
                    {
                        case "n":
                            ladoAtualSegundoRobo = "l";
                            break;
                        case "l":
                            ladoAtualSegundoRobo = "s";
                            break;
                        case "s":
                            ladoAtualSegundoRobo = "o";
                            break;
                        case "o":
                            ladoAtualSegundoRobo = "n";
                            break;
                    }
                }
                else if (lerDadosTelaSegundoRobo[i].ToString() == "m")//Avançar robô
                {
                    if (ladoAtualSegundoRobo == "n" && tamanhoMaximoY >= (coordenadaAtualSegundoRobo[1] + 1))
                    {
                        coordenadaAtualSegundoRobo[1] += 1;
                    }
                    else if (ladoAtualSegundoRobo == "o" && tamanhoMinimoX <= (coordenadaAtualSegundoRobo[0] - 1))
                    {
                        coordenadaAtualSegundoRobo[0] -= 1;
                    }
                    else if (ladoAtualSegundoRobo == "s" && tamanhoMinimoY <= (coordenadaAtualSegundoRobo[1] - 1))
                    {
                        coordenadaAtualSegundoRobo[1] -= 1;
                    }
                    else if (ladoAtualSegundoRobo == "l" && tamanhoMaximoX >= (coordenadaAtualSegundoRobo[0] + 1))
                    {
                        coordenadaAtualSegundoRobo[0] += 1;
                    }
                }
            }

            //saída
            Console.WriteLine("{0} {1} {2}", coordenadaAtualPrimeiroRobo[0], coordenadaAtualPrimeiroRobo[1], ladoAtualPrimeiroRobo);
            Console.WriteLine("{0} {1} {2}", coordenadaAtualSegundoRobo[0], coordenadaAtualSegundoRobo[1], ladoAtualSegundoRobo);
            Console.ReadKey();
        }
    }
}