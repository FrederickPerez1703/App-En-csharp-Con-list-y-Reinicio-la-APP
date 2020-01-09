using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {


        static void Main(string[] args)
        {
            const int REINICIAR = 1;
            const int SALIR = 2;
            const int SEGUIR = 3;

            int estado = 0;

            int opcion;

            int datosEntrada;
            int contador = 1;
            List<string> lista_string = new List<string>();

            List<int> lista_int = new List<int>();
            do
            {
                try
                {
                    Console.Write("Porfavor No inserta una letra o un caracter estraño la App . (GRACIAS..)");
                    Console.WriteLine();
                    Console.WriteLine("Inserte la cantidad de veces que decea guardar un dato");

                    datosEntrada = Int32.Parse(Console.ReadLine());


                    lista_int.Add(datosEntrada);

                    for (int i = 0; i < datosEntrada; i++)
                    {

                        Console.WriteLine("Inserta la informacion que decea");

                        string datos = Console.ReadLine();

                        lista_string.Add(datos);

                    }
                    Console.WriteLine("Resultado");
                    for (int j = 0; j < lista_string.Count; j++)
                    {
                        Console.WriteLine($"Los datos de la posicion {contador} es:" + lista_string[j]);
                        contador++;
                        Console.WriteLine();
                    }
                }
                catch
                {
                    Console.WriteLine("No puede presionar Numero ni caracteres raros como (/*-~!@#$%^&*()_+)");
                }
                
                do
                {
                    try
                    {
                        Console.WriteLine("Presione 1 : para reinicir la aplicacion " + " O  " + "Presiones 2 : para salir de la aplicacion.");
                        Console.WriteLine("\t\t1-Reset");
                        Console.WriteLine("\t\t2-Salir");
                       

                        opcion = Convert.ToInt32(Console.ReadLine());
                        estado = SEGUIR;

                        switch (opcion)
                        {
                            case REINICIAR:
                                Console.WriteLine("Esta seguro que desea reiniciar las App? [S/N]");
                                Console.WriteLine();
                                if (Console.ReadLine().ToUpper() == "S")
                                    estado = REINICIAR;
                                Console.Clear();
                                break;
                            case SALIR:
                                estado = SALIR;
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("No puede presionar Numero ni caracteres raros como (/*-~!@#$%^&*()_+)");
                        
                    }
                }
                while (estado == SEGUIR);

            } while (estado == REINICIAR);


        }

       
    }
}
