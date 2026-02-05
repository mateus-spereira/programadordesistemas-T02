using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Carro
    {
        public string Marca
            { get; set; }
        private string Modelo
            { get; set; }
        private int Ano;

        public int ano
        {
            get { return ano; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                {
                    Ano = value;
                }
                else
                {
                    Console.WriteLine("Ano inválido");
                }
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }

        public int CalcularIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - Ano;
        }

        public void DefinirModelo (string modelo)
        {
            Modelo = modelo;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando um objeto da classe carro
            Carro meuCarro = new Carro();

            //Atribuindo calores ás proptriedades públicas e privadas
            meuCarro.Marca = "Toyota";
            meuCarro.DefinirModelo("Corolla");
            meuCarro.ano = 2020;

            // Exibindo as informações de carro
            meuCarro.ExibirInformacoes();

            int idadeCarro = meuCarro.CalcularIdade();
            Console.WriteLine($"Idade do carro: {idadeCarro} anos.");

            Console.ReadLine();


        }
    }

}