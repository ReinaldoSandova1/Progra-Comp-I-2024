using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloque1Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";
            while (continuar == "s")
            {

                Console.WriteLine("Guia De Ejercicios Bloque 1 Actividad 1");
                Console.WriteLine("1. Ejercicio 1 Negativo Positivo");
                Console.WriteLine("2. Ejercicio 2 Tabla de Multiplicar del 1-10");
                Console.WriteLine("3. Ejercicio 3 Suma Numero Positivos");
                Console.WriteLine("4. Ejercicio 4 Numeros primos o no primos");
                Console.WriteLine("5. Ejercicio 5 Calcular el promedio de numeros");
                Console.WriteLine("6. Salir");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    int numero;
                    while (true)
                    {
                        Console.Write("Ingrese un número (0 para salir): ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        if (numero == 0)
                        {
                            Console.WriteLine("El programa ha finalizado.");
                            break;
                        }

                        if (numero > 0)
                        {
                            Console.WriteLine("El número es positivo.");
                        }
                        else
                        {
                            Console.WriteLine("El número es negativo.");
                        }
                    }
                }
                else if (opcion == 2)
                {
                    int numero;

                    while (true)

                    {
                        Console.WriteLine("Ingrese un número entre 1 y 10 (0 para salir): ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        if (numero == 0)
                        {
                            Console.WriteLine("El programa ha finalizado.");
                            break;
                        }
                        if (numero >= 1 && numero <= 10)
                        {
                            Console.WriteLine($"Tabla de multiplicar del {numero}:");
                            for (int i = 1; i <= 10; i++)
                            {
                                Console.WriteLine($"{numero} x {i} = {numero * i}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número fuera de rango. Por favor, ingrese un número entre 1 y 10.");
                        }
                    }
                }
                else if (opcion == 3)
                {
                    int numero;
                    int suma = 0;

                    do
                    {
                        Console.Write("Ingrese un número positivo (0 o negativo para terminar): ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        if (numero > 0)
                        {
                            suma += numero;
                        }
                    } while (numero > 0);
                    Console.WriteLine($"La suma de todos los números ingresados es: {suma}");
                }
                else if (opcion == 4)
                {
                    
                    int n = 0;
                    int c = 0;
                    do
                    {
                        Console.WriteLine("Determinar si un numero es primo:");
                        Console.WriteLine("Ingrese un Numero (0 para salir):");
                        n = Convert.ToInt32(Console.ReadLine());

                        if (n == 0)
                        {
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        }

                        c = 0;

                        for (int i = 1; i < (n + 1); i++)
                        {
                            if (n % i == 0)
                            {
                                c++;
                            }
                        }
                        if (c != 2)
                        {
                            Console.WriteLine("No Es Primo");
                        }
                        else
                        {
                            Console.WriteLine("Es Primo");
                        }
                    }while (n != 0);
                }

                else if (opcion == 5)
                {
                    int numero;
                    int suma = 0;
                    int contador = 0;

                    do
                    {
                        Console.Write("Ingrese un número (0 para finalizar): ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        if (numero != 0)
                        {
                            suma += numero;
                            contador++;
                        }
                    } while (numero != 0);
                    if (contador > 0)
                    {
                        double promedio = (double)suma / contador;
                        Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
                    }
                    else
                    {
                        Console.WriteLine("No se ingresaron números válidos para calcular el promedio.");
                    }
                }
                else if (opcion >= 6)
                {
                    continuar = "n";
                    break;
                }
            }
        }
    }
}