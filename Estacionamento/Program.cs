
//declarando var

using Estacionamento;

decimal precoInicial = 0;
decimal precoHora = 0;

//iniciar o sistema

Console.WriteLine("sejam bem vindos");
Console.WriteLine("-------------------------");

Console.WriteLine("Digite o preço Inicial");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Qual o preço por hora: ");
precoHora = Convert.ToDecimal(Console.ReadLine());

//Instancia a classe Estacionamento
Parkinglot es = new Parkinglot(precoInicial, precoHora);

//Loop

bool menu = true;

while (menu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine("1 - Adicionar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículo");
    Console.WriteLine("4 - Sair do Sistema");

    switch (Console.ReadLine())
    {
        case "1":
            es.adicionarVeiculo();
            break;

        case "2":
            es.removerVeiculo();
            break;

        case "3":
            es.listarVeiculo();
            break;

        case "4":
            menu = false;
            break;

        default:
            break;

    }

    Console.WriteLine("digite uma tecla para continuar");
    Console.ReadLine();
}

