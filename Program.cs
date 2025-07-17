string mensagemBoasVindas = "Bem vindo ao Comumusic";

void ExibirLogo()
{
    Console.WriteLine(@"
        █▀▀ █▀█ █▀▄▀█ █░█ █▀▄▀█ █░█ █▀ █ █▀▀
        █▄▄ █▄█ █░▀░█ █▄█ █░▀░█ █▄█ ▄█ █ █▄▄
    ");
    Console.WriteLine(mensagemBoasVindas);
};

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerica);
            break;
        case 3:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Tchau!");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    
}

void RegistrarBanda()
{
    // Console.Clear(); << Roberta Nascimento, 17/7/2025, 11:46 - O comando produz um erro no VSCode
    Console.WriteLine("Registro das bandas");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    Console.WriteLine($"{nomeBanda} foi registrada");
    Thread.Sleep(2000);
    ExibirOpcoesMenu();
}

ExibirOpcoesMenu();