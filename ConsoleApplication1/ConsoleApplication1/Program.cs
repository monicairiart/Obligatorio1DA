using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Recorrido a = new Recorrido();
            List<Tuple<double, double>> personasUbicacion = new List<Tuple<double, double>>
            {
                new Tuple<double, double> (1,0),
                new Tuple<double, double> (4,0),
                new Tuple<double, double> (3,0),
                new Tuple<double, double> (2,0)
            };
            List<int> personas = new List<int>
            {
                1,2,34
            };
            var distancias = a ArmarDistancias(personasUbicacion);
            var camino = a.EncontrarUnCamino(distancias,
                personas, 4);
            foreach (var persona in camino.Item1)
            {
                Console.Write(persona + " ");
            }
            Console.WriteLine();
            Console.WriteLine(camino.Item2);
            Console.ReadKey();
        }
    }
}
