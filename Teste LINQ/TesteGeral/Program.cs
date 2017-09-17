using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TesteGeral
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Carro> carros = new List<Carro>()
            {
                new Carro(){Marca = "Renault", Placa="a1", Modelo = "Sandero", Ano = 2010, Preco = 33000},
                new Carro(){Marca = "Fiat", Placa="b2", Modelo = "Logan", Ano = 2013, Preco = 37000},
                new Carro(){Marca = "Ford", Placa="c3", Modelo = "Focus", Ano = 2015, Preco = 43000},
                new Carro(){Marca = "Lamborghini", Placa="d4", Modelo = "Gallardo", Ano = 2007, Preco = 120000},
                new Carro(){Marca = "Hyunday", Placa="e5", Modelo = "I30", Ano = 2010, Preco = 57000}
            };

            // LINQ Query
            var ano2010 = from car in carros where car.Ano == 2010 select car;
            var anoDescendente = from car in carros orderby car.Ano descending select car;

            // LINQ Method
            var ano2010j = carros.Where(carro => carro.Ano == 2010).OrderByDescending(carro => carro.Ano);
            var anoDescendentes = carros.OrderByDescending(carro => carro.Ano);
            var maior2007 = carros.TrueForAll(carro => carro.Ano >= 2007);

            carros.ForEach(p => Console.WriteLine("{0}", p.Ano -= 2));
            carros.ForEach(p => Console.WriteLine("{0}", p.Marca));

            foreach (var car in ano2010j)
            {
                Console.WriteLine("Marca: {0}, Modelo: {1}, Placa: {2}, Preço: {3}, Ano: {4}", car.Marca, car.Modelo, car.Placa, car.Preco, car.Ano);
            }

            var newCars = from car in carros where car.Ano >= 2007 select new{car.Ano, car.Modelo};

            foreach (var item in newCars)
            {
                Console.WriteLine("{0}, {1}", item.Ano, item.Modelo);
            }

            Console.ReadKey();
        }

        class Carro
        {
            public string Modelo { get; set; }
            public string Marca { get; set; }
            public int Ano { get; set; }
            public string Placa { get; set; }
            public decimal Preco { get; set; }
        } 

        class Casa
        {
            public int NumeroQuartos { get; set; }
            public bool Suite { get; set; }

            public Casa(int quartos, bool suite = false)
            {
                this.NumeroQuartos = quartos;
                this.Suite = suite;
            }
        }

    }
}
