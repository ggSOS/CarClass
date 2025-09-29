using CarClass;
using System.Collections.Generic;

namespace Ambiente1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Carro> listaDeCarros = new List<Carro>();

            Carro carro1 = new Carro("Uno", "asd2b345", "Vermelho", "Combustao");
            listaDeCarros.Add(carro1);
            Carro carro2 = new Carro("Audi", "oiu6s789", "Cinza", "Combustao");
            listaDeCarros.Add(carro2);
            Carro carro3 = new Carro("Dodge Ram", "xcv7g234", "Preto", "Combustao");
            listaDeCarros.Add(carro3);
            Carro carro4 = new Carro("Hylux", "fgh5q456", "Branco", "Combustao");
            listaDeCarros.Add(carro4);
            Carro carro5 = new Carro("BYD", "cft6d346", "Azul", "Elétrico");
            listaDeCarros.Add(carro5);
            Carro carro6 = new Carro("Palio", "dhf3t789", "Branco", "Combustao");
            listaDeCarros.Add(carro6);
            Carro carro7 = new Carro("Corsa", "sdb6t143", "Cinza", "Combustao");
            listaDeCarros.Add(carro7);
            Carro carro8 = new Carro("Kwid", "sbd3h521", "Vermelho", "Combustao");
            listaDeCarros.Add(carro8);
            Carro carro9 = new Carro("Fusca", "bsr4u745", "Aul", "Fe");
            listaDeCarros.Add(carro9);
            Carro carro10 = new Carro("Idea", "ach5q942", "Cinza", "Combustao");
            listaDeCarros.Add(carro10);

            for (int count = 0; count < listaDeCarros.Count; count++)
            {
                Console.WriteLine("{0}º Carro:\n{1}", count + 1, listaDeCarros[count].ToString());
            }
        }
    }
}