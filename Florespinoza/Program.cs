using Florespinoza;
using System;

namespace Florespinoza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada miLista = new ListaEnlazada();
            int opcion = 0;

            do
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1. INSERTAR AL INICIO");
                Console.WriteLine("2. INSERTAR AL FINAL");
                Console.WriteLine("3. MOSTRAR");
                Console.WriteLine("4. ELIMINAR");
                Console.WriteLine("5. ENCONTRAR NODO MEDIO");
                Console.WriteLine("6. INVERTIR LISTA");
                Console.WriteLine("7. SALIR");
                Console.Write("SELECCIONE UNA OPCIÓN: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("INGRESE LA CANTIDAD DE LOS NÚMEROS A INSERTAR AL INICIO: ");
                        int cantidadInicio = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cantidadInicio; i++)
                        {
                            Console.Write($"INGRESE EL VALOR {i + 1}: ");
                            int valorInsertarInicio = Convert.ToInt32(Console.ReadLine());
                            miLista.InsertarInicio(valorInsertarInicio);
                        }
                        break;

                    case 2:
                        Console.Write("INGRESE LA CANTIDAD DE LOS NÚMEROS A INSERTAR AL FINAL: ");
                        int cantidadFinal = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cantidadFinal; i++)
                        {
                            Console.Write($"INGRESE EL VALOR {i + 1}: ");
                            int valorInsertarFinal = Convert.ToInt32(Console.ReadLine());
                            miLista.InsertarFinal(valorInsertarFinal);
                        }
                        break;

                    case 3:
                        miLista.Mostrar();
                        break;

                    case 4:
                        Console.Write("INGRESE EL VALOR A ELIMINAR: ");
                        int valorEliminar = Convert.ToInt32(Console.ReadLine());
                        miLista.EliminarNodo(valorEliminar);
                        break;

                    case 5:
                        miLista.EncontrarNodoMedio();
                        break;

                    case 6:
                        miLista.InvertirLista();
                        break;

                    case 7:
                        Console.WriteLine("SALIENDO DEL PROGRAMA...");
                        break;

                    default:
                        Console.WriteLine("OPCIÓN NO VÁLIDA. INTENTE NUEVAMENTE.");
                        break;
                }

                Console.WriteLine();

            } while (opcion != 7);
        }
    }
}