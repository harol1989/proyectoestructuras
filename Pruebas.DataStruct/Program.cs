using System;
using DataStructs;

namespace Pruebas.DataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de elementos de la lista:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Agregar un Nodo al final: 1=si ");
            int nodofinal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Agregar un Nodo al inicial: 1=si ");
            int nodoinicial = Convert.ToInt32(Console.ReadLine());


            SingleList<int> listaDeEnteros = new SingleList<int>();

            Random random = new Random();


            for (int i = 0; i < cantidad; i++)
            {
                int nuevoNumero = random.Next(0, 100);
                listaDeEnteros.AddNode(nuevoNumero);


                if (i == cantidad - 1)
                {
                   
                    Console.Write(" ");
                    if (nodofinal == 1)
                    {


                        listaDeEnteros.AddNodefinal(56);
                    }
                   
                    if (nodoinicial == 1)
                    {
                        listaDeEnteros.AddNodeinicial(23);
                    }

                }
            }


            listaDeEnteros.ImprimirLista();

          


            Console.Read();
        }
    }
}
