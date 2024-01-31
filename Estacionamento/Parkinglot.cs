using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    internal class Parkinglot
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Parkinglot(decimal precoInicial, decimal precoHora) 
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void adicionarVeiculo()
        {
            Console.Write("digite a placa do veículo: ");
            string placa = Console.ReadLine();

            if ( veiculos.Any(x => x.Equals(placa.ToUpper())) )
            {
                Console.WriteLine("Já existe veículo com essa placa");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo cadastrado com sucesso");
            }
        }

        public void removerVeiculo()
        {
            Console.Write("digite a placa do veículo: ");
            string placa = Console.ReadLine().ToUpper();

            if( veiculos.Any(x => x.ToUpper() == placa))
            {
                Console.Write("Digite a quantidade de horas: ");
                decimal horas = Convert.ToDecimal(Console.ReadLine());
                decimal total = precoInicial + precoHora * horas;

                Console.WriteLine($"Placa: {placa}");
                Console.WriteLine($"Horas: {horas}");
                Console.WriteLine($"Total: {total}");

                veiculos.Remove(veiculos.First(x => x.ToUpper() == placa));
                
                
            }
            else
            {
                Console.WriteLine("Veículo não cadastrado");
            }

        }

        public void listarVeiculo()
        {
            if (veiculos.Any())
            {
                Console.Write("Os veículos estacionados são");
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item);
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados");
            }
        }
    }
}
