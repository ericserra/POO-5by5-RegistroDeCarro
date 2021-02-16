using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ_POO_CadastroDeCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            string chassis = null, placa = null, marca = null, modelo = null, cor = null, nome = null, logradouro = null, dataNasc = null, dataComp = null, localidade = null;
            double renavam = 0, ano = 0, cpf = 0, numCasa = 0;
            do
            {
                
                Console.Clear();
                Console.WriteLine("#**************************************#");
                Console.WriteLine("#                                      #");
                Console.WriteLine("# ---       MENU PRINCIPAL        ---  #");
                Console.WriteLine("#                                      #");
                Console.WriteLine("# 1 -    Informar todos os dados       #");
                Console.WriteLine("# 2 -    Imprimir informações          #\n#\t Cadastradas                   #");
                Console.WriteLine("# 3 -    Sair                          #");
                Console.WriteLine("# ---                              --- #");
                Console.WriteLine("#                                      #");
                Console.WriteLine("#**************************************#");
                Console.WriteLine();
                Console.Write("Digite sua opcao: ");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("\nPrimeiro vamos começar com seu cadastro pessoal!");
                        Console.Write("\nDigite aqui seu nome Completo: ");
                        nome = Console.ReadLine();
                        Console.Write("\nAgora informe seu CPF(obs: sem o digito): ");
                        cpf = double.Parse(Console.ReadLine());
                        Console.Write("\nAgora informe o seu logradouro: ");
                        logradouro = Console.ReadLine();
                        Console.Write("\nAgora informe o numero de sua casa: ");
                        numCasa = int.Parse(Console.ReadLine());
                        Console.Write("\nAgora informe sua cidade: ");
                        localidade = Console.ReadLine();
                        Console.WriteLine("\nIniciando Cadastro do Carro...\n");
                        Console.Write("Informe o seu Renavam: ");
                        renavam = double.Parse(Console.ReadLine());
                        Console.Write("\nInforme o número da placa: ");
                        placa = Console.ReadLine();
                        Console.Write("\nInformE O número do chassis: ");
                        chassis = Console.ReadLine();
                        Console.Write("\nInforme a marca do seu carro: ");
                        marca = Console.ReadLine();
                        Console.Write("\nInforme o modelo do seu carro: ");
                        modelo = Console.ReadLine();
                        Console.Write("\nInforme a cor de seu carro: ");
                        cor = Console.ReadLine();
                        Console.Write("\nInforme o ano do carro: ");
                        ano = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nCadastro computado com sucesso. Retornando para o menu inicial");
                        Console.Write("\nSe deseja voltar ao menu inicial digite *s*, senão digite *n*: ");
                        string voltar = "";
                        voltar = Console.ReadLine();
                        if (voltar == "s")
                        {
                            menu = 4;
                            Console.Clear();
                        }
                        else
                        {
                            menu = 3;
                        }
                            break;

                    case 2:
                        Proprietario p1 = new Proprietario
                        {
                            Nome = nome,
                            CPF = cpf,
                            endereco = new Endereco
                            {
                                Logradouro = logradouro,
                                Numero = numCasa,
                                Localidade = localidade,

                            },
                            carro = new Carro
                            {
                                Renavam = renavam,
                                NumPlaca = placa,
                                NumChassi = chassis,
                                Marca = marca,
                                Modelo = modelo,
                                Cor = cor,
                                Ano = ano,


                            },
                            DataNasc = dataNasc,
                            DataCompra = dataComp,


                        };
                        Console.WriteLine("#************************************************");
                        Console.WriteLine("      ---           Cadastro          ---  ");
                        Console.WriteLine("      ---              do             ---  ");
                        Console.WriteLine("      ---         Propriétario        ---  ");
                        Console.WriteLine("                Nome Completo: "+p1.Nome);
                        Console.WriteLine("                CPF: "+p1.CPF);
                        Console.WriteLine("                Logradouro: "+p1.endereco.Logradouro);
                        Console.WriteLine("                Numero: "+p1.endereco.Numero);
                        Console.WriteLine("                Cidade: "+p1.endereco.Localidade);
                        Console.WriteLine("                                       ");
                        Console.WriteLine("      ---           Cadastro          ---  ");
                        Console.WriteLine("      ---           do carro          ---  ");
                        Console.WriteLine("                Renavam: "+p1.carro.Renavam);
                        Console.WriteLine("                Placa: "+p1.carro.NumPlaca);
                        Console.WriteLine("                Numero do Chassi: "+p1.carro.NumChassi);
                        Console.WriteLine("                Marca: "+p1.carro.Marca);
                        Console.WriteLine("                Modelo:"+p1.carro.Modelo);
                        Console.WriteLine("                Cor: "+p1.carro.Cor);
                        Console.WriteLine("                Ano do Carro: "+p1.carro.Ano);


                        Console.Write("\nSe deseja voltar ao menu inicial digite *s*, senão digite *n*: ");
                        string voltar2 = "";
                        voltar2 = Console.ReadLine();
                        if (voltar2 == "s")
                        {
                            menu = 4;
                            Console.Clear();
                        }
                        
                        break;

                    case 3:
                        break;


                    default:
                        break;
                }
            } while (menu >= 4);

            Console.WriteLine("Aperte enter para sair...");
            Console.ReadKey();
        }
    }
}
