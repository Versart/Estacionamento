using desafio;

internal class Program
{
    private static void Main(string[] args)
    {
        Estacionamento estacionameto = new Estacionamento(10);
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("1 - Entrada de veículo\n2 - Saída de veículo\n3 - Visualizar veículos estacionados\n4 - Sair");
            opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
                
                case 1:
                    Console.WriteLine("Qual o tipo de veículo:\n1 - Carro\n2 - Moto");
                    int tipoCarro = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if(tipoCarro == 1)
                    {
                        Console.WriteLine("Digite a placa do carro:");
                        string placaa = Console.ReadLine();
                        Console.WriteLine("Digite o modelo do carro");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("Digite a marca do carro");
                        string marca = Console.ReadLine();
                        Carro carro = new Carro(placaa,modelo,marca);
                        estacionameto.adicionarVeiculo(carro);
                        Console.WriteLine("Carro adicionado");
                        Console.WriteLine("Digite qualquer tecla para continuar");
                        Console.ReadLine();

                    }
                    else if(tipoCarro == 2)
                    {
                        Console.WriteLine("Digite a placa da moto:");
                        string placaa = Console.ReadLine();
                        Console.WriteLine("Digite o modelo da moto");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("Digite a marca da moto");
                        string marca = Console.ReadLine();
                        Moto moto = new Moto(placaa, modelo, marca);
                        estacionameto.adicionarVeiculo(moto);
                        Console.WriteLine("Moto adicionada");
                        Console.WriteLine("Digite qualquer tecla para continuar");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("Digite qualquer tecla para continuar");
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Digite a placa do veículo:");
                    string placa = Console.ReadLine();
                    if(estacionameto.VeiculoExiste(placa))
                    {
                        Console.WriteLine("Digite a quantidade de horas estacionado:");
                        int quantidadeHoras = int.Parse(Console.ReadLine());
                        double valor = estacionameto.SaidaVeiculo(placa,quantidadeHoras);
                        Console.WriteLine($"Valor a ser pago: {valor}");
                        Console.WriteLine("Digite qualquer tecla para continuar");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Veículo não encontrado");
                        Console.WriteLine("Digite qualquer tecla para continuar");
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("Veículos estacionados");
                    foreach(Veiculo veiculo in estacionameto.veiculosEstacionados)
                    {
                        Console.WriteLine(veiculo.ToString());
                    }
                    Console.WriteLine("Digite qualquer tecla para continuar");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Programa encerrado!");
                    Console.WriteLine("Digite qualquer tecla para continuar");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Digite qualquer tecla para continuar");
                    Console.ReadLine();
                    break;
            }
            
        } while (opcao != 4);
        

    }
}