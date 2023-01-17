// See https://aka.ms/new-console-template for more information
using Projeto_Dio.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        

        Boolean op = true;

        Console.WriteLine("Bem vindo ao sistema de Estacionamento");
        Console.Write("Digite o preço inicial: ");
        double precoInicial = double.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.Write("Digite o preço por Horas: ");
        double preco = double.Parse(Console.ReadLine());
        Estacionamento estacionamento = new Estacionamento(preco, precoInicial);
        Console.WriteLine();
        Console.Clear();

        while(op != false){
            Console.WriteLine("1 -  Cadastrar Placa (Veículo)");
            Console.WriteLine("2 -  Remover Placa (Veículo)");
            Console.WriteLine("3 -  Listar Placas (Veículo)");
            Console.WriteLine("4 -  Encerrar ");
            string opcao = Console.ReadLine();

            switch (opcao){
                case "1":
                    estacionamento.cadastrarVeiculo();
                    Console.WriteLine("Placa Inserida com sucesso !");
                    Console.Clear();
                break;
                case "2":
                    Console.Write("Digite a Placa para Remover: ");
                    string placa = Console.ReadLine();
                    estacionamento.removerVeiculo(placa);
                    Console.WriteLine("Quantas horas o Veiculo permaneceu? ");
                    double horas = double.Parse(Console.ReadLine());
                    estacionamento.calcularPreço(horas, preco, precoInicial);
                break;
                case "3":
                    Console.WriteLine("Placas Listadas abaixo: ");
                    estacionamento.listarPlacas();
                break;
                case "4":
                    Console.WriteLine(" !!! ENCERRANDO !!!");
                    Console.Clear();
                    op = false;
                break;
                default:
                    Console.WriteLine("Opção Inválidade");
                break;
            }
        }
       
    }
}