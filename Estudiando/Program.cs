// See https://aka.ms/new-console-template for more information
//String[] listaCompras = {"Leche", "Pan", "Lechuga", "Carne"};
//foreach(string elemento in listaCompras)
//{
//    Console.WriteLine(elemento + ",");
//}

using System.Security.Cryptography.X509Certificates;
using System.Timers;

//int[] numero = { 23, 45, 456, 567, 67 };

//int suma = 0;
//foreach (int elemento in numero)
//{
//    suma = suma + elemento; 
//}

//for (int i = 0; i < numero.Length; i++)
//{

//    Console.WriteLine($"El número {numero[i]} + {suma} es igual a {suma = suma + numero[i]}");

//}


        var nombres = new string[5];
        var apellidos = new string[5];
        var edades = new int[5];
        var sexos = new char[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Ingrese los datos de la persona {i + 1}:");
            Console.Write("Nombre: ");
            nombres[i] = Console.ReadLine();
    Console.Clear();

            Console.Write("Apellido: ");
            apellidos[i] = Console.ReadLine();
    Console.Clear();

            Console.Write("Edad: ");
            edades[i] = int.Parse(Console.ReadLine());
    Console.Clear();

            Console.Write("Sexo (M/F): ");
            sexos[i] = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
    Console.Clear();
        }


        Console.WriteLine("\nDatos ingresados:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Persona {i + 1} - Nombre: {nombres[i]}, Apellido: {apellidos[i]}, Edad: {edades[i]}, Sexo: {sexos[i]}");
        }






