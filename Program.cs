﻿string mensagemBoasVindas = "Bem vindo ao Comumusic";

void ExibirMensagemBoasVindas()
{
    Console.WriteLine(@"
        █▀▀ █▀█ █▀▄▀█ █░█ █▀▄▀█ █░█ █▀ █ █▀▀
        █▄▄ █▄█ █░▀░█ █▄█ █░▀░█ █▄█ ▄█ █ █▄▄
    ");
    Console.WriteLine(mensagemBoasVindas);
};

void ExibirOpcoesMenu()
{
    Console.WriteLine("Digite 1 para registrar uma banda");  
    Console.WriteLine("Digite 2 para mostrar todas as bandas");  
    Console.WriteLine("Digite 3 para avaliar uma banda");  
    Console.WriteLine("Digite 4 para exibir a média de uma banda");  
    Console.WriteLine("Digite -1 para sair");  
};

ExibirMensagemBoasVindas();
ExibirOpcoesMenu();