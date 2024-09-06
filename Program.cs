using System;
using System.Threading;
using Testes.Entities;

Console.WriteLine("\n --- SEJA BEM VINDO AO SISTEMA DE ESTACIONAMENTO --- \n");

Console.Write(" Digite o preço inicial: R$");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.Write(" Digite o preço por hora: R$");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);
Console.Clear();

while (true)
{
    Console.WriteLine("\n 1 - Cadastrar Veículo");
    Console.WriteLine(" 2 - Remover Veículo");
    Console.WriteLine(" 3 - Listar Veículos");
    Console.WriteLine(" 4 - Sair");

    Console.Write("\n Digite a sua opção: ");
    int opcao = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcao)
    {
        case 1:
            es.AdicionarVeiculo();
            break;
        case 2:
            es.RemoverVeiculo();

            break;
        case 3:
            es.ListarVeiculos();
            break;
        case 4:
            es.Sair();
            break;
        default:
            Console.WriteLine("Opção Inválida.");
            break;
    }
}
