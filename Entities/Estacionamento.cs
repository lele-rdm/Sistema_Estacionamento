using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Entities
{
    class Estacionamento
    {
        public decimal PrecoInicial { get; private set; }
        public decimal PrecoPorHora { get; private set; }

        private List<string> Veiculos = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("\n Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            Veiculos.Add(placa);
            Console.WriteLine("\n Adicionando veículo...");
            Thread.Sleep(2000);
            Console.WriteLine(" Veículo adicionado com sucesso! ");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void RemoverVeiculo()
        {
            Console.Write("\n Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            Console.Write(" Digite a quantidade de horas utilizadas: ");
            int horasEstacionadas = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Removendo veículo...");
            Thread.Sleep(2000);
            Console.WriteLine($"\n O veículo {placa} foi removido com sucesso! ");
            Console.WriteLine($" O preço total foi de: R${CalcularPrecoTotal(horasEstacionadas)}");
            Veiculos.Remove(placa);
            Console.Write("\nPressione enter para voltar: ");
            string resp = Console.ReadLine();
            if (resp == "")
            {
                Console.Clear();
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("\n --- Veículos Adicionados ---\n");
            foreach (string v in Veiculos)
            {
                Console.WriteLine($" {v}");
            }
            Console.Write("\nPressione enter para voltar: ");
            string resp1 = Console.ReadLine();
            if (resp1 == "")
            {
                Console.Clear();
            }
        }

        public void Sair()
        {
            Console.WriteLine("\n Saindo...");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }

        public decimal CalcularPrecoTotal(decimal horasEstacionadas)
        {
            decimal precoTotal = PrecoInicial + PrecoPorHora * horasEstacionadas;
            return precoTotal;
        }
    }
}
