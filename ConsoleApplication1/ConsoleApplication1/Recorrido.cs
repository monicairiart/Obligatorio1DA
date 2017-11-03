using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Recorrido
    {
        private void RecorridoBacktracking(
            List<int> personasDisponibles,
            List<Tuple<int, int>> camionetas,
            ref double distanciaResultado, ref double distanciaTemp)
            ref List<Tuple<int>>
        {
            if (personasDisponibles.Count == 0)
            {
                if (distanciaResultado > distanciaTemp)
                {
                    distanciaResultado = distanciaTemp;
                    recorridoResultado.Clear();
                    recorridoResultado.AddRange(recorridoTemp);
                }
            }
            else
            {
                foreach(var item in)
            }



            else
            {

            }
        }
        public double[,] ArmarDistancias(List<Tuple<double, double>> ubicacionPersonas)
        {
            List<Tuple<double, double>> puntos = new List<Tuple<double, double>>
            {
                new Tuple<double, double>(0,0)
            };
            puntos.AddRange(ubicacionPersonas);
            double[,] distancias = new double[puntos.Count, puntos.Count];
            for (int i = 0; i < puntos.Count; i++)
            {
                for (int j=0; j < puntos.Count; j++)
                {
                    var puntI = puntos.ElementAt(i);
                    var puntoJ = puntos.ElementAt(j);
                    distancias[i,j]= Math.Sqrt(
                        Math.Pow(puntoI.Item1 - puntoJ.Item1,2)
                        +
                        Math.Pow(puntoI.Item2 - puntoJ.Item2,2)

                }
            }
        }
        public Tuple<List<int>, double> EncontrarUnCamino(double[,] distancias,
            List<int> personasDisponibles, int capacidadCamioneta)
        {
            double distanciaResultado = double.MaxValue;
            double distanciaTemp = 0;
        List<int> listaResultado = new List<int>();  // ok
        List<int> listaTemp = new List<int> {0};
            int capacidad = (personasDisponibles.Count > capacidadCamioneta ?
                    capacidadCamioneta;personasDisponibles.Count);
            EncontrarUnCaminoBacktracking(distancias, personasDisponibles,
                capacidad + 1, ref listaResultado, ref distanciaResultado,
                ref listaTermp, ref distanciaTemp);
            return new Tuple<List<int>, double>(listaResultado, distanciaResultado);
        }
        private void EncontrarUnCaminoBacktracking(double[,] distancias, List<int>)
        {
            if (capacidad == listaTemp.Count)
            {
                int anterior = listaTemp.Last();
                double distancia = distancias[anterior, 0];
                listaTemp.Add(0);
                distanciaTemp += distancia;
                if(distanciaTemp<distanciaResultado)
                {
                    distanciaResultado = distanciaTemp;
                    listaResultado.Clear();
                    listaResultado.AddRange(listaTemp);
                }
                distanciaTemp -= distancia;
                listaTemp.RemoveAt(listaTemp.Count - 1);
            }
            else
            {
                foreach (int persona in personasDisponibles)
                {
                    if (!listaTemp.Contains(persona))
                    {
                        double distancia = 0;
                        if (listaTemp.Count != 0)
                        {
                            ///////
                        }
                    }
                }
            }
        }
         
        else
        {
             foreach (int persona in personasDisponibles)
             {
                if (!listaTemp.Contains(persona))
                {
                    double distancia = 0;
                    if (listaTemp.Count != 0)
                    {
                        int anterior = listaTemp.Last();
                        distancia = distancias[anterior,]
                    }
                }
            }
        }

        }
    }
}
