string mensagemBoasVindas = "Bem vindo ao Comumusic";
// List<string> bandas = new List<string>();
// List<string> bandas = new List<string>{"My Chemical Romance", "Pink Floyd", "Sleeping at Last"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>()); 
bandasRegistradas.Add("Blackpink", new List<int>{10, 8, 9});

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
            MostrarBanda();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirNotaMedia();
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
    // Console.Clear(); << Roberta Nascimento, 17/7/2025, 11:46 >> O comando produz um erro no VSCode
    Console.WriteLine("Registro das bandas");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    // bandasRegistradas.Add(nomeBanda);
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"{nomeBanda} foi registrada");
    Thread.Sleep(2000);
    ExibirOpcoesMenu();
}

void MostrarBanda()
{
    Console.WriteLine("Bandas registradas: \n");
    // for (int i = 0; i < bandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {bandas[i]}");
    // }
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Thread.Sleep(2000);
    // Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
    // Console.ReadKey(); << Roberta Nascimento, 21/7/2025, 13:48 >> O comando produz um erro no VSCode
    ExibirOpcoesMenu();
}

void AvaliarBanda()
{
    Console.Write("Digite a banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write("Qual nota essa banda merece?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine("Nota registrada!");
    }
    else
    {
        Console.WriteLine("Banda não encontrada!");
    }
    Thread.Sleep(2000);
    ExibirOpcoesMenu();
}

void ExibirNotaMedia()
{
    Console.Write("Digite a banda que deseja visualizar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        // double mediaBanda = 0;
        // int count = 0;
        // double nota;
        // foreach (double notas in bandasRegistradas[nomeBanda])
        // {
        //     count++;
        //     notas = nota + notas;
        // }
        // mediaBanda = mediaBanda/count;
        // Console.Write($"{bandasRegistradas[nomeBanda]} tem a média {mediaBanda}"); << Roberta Nascimento, 21/7/2025, 15:00 >> Solução da Roberta, seguida pela solução
        List<int> notasDaBanda = bandasRegistradas[nomeBanda];
        Console.WriteLine($"A média das notas de {nomeBanda} é {notasDaBanda.Average()}");
    }
    else
    {
        Console.Write("Banda não encontrada");
    }
    Thread.Sleep(2000);
    ExibirOpcoesMenu();
}

ExibirOpcoesMenu();