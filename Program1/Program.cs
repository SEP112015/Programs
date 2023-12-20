// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int valor = 28;

//Console.WriteLine($"El numero que contiene la variable valor es: {valor}");


// Switch-Case


//Console.WriteLine("Introduce el lugar en el que quedaste");
// int valor = int.Parse(Console.ReadLine()) ;

//switch (valor)
//{

//    case 1:
//        Console.WriteLine("Quedó en primer lugar");
//        break;
//    case 2:
//        Console.WriteLine("Quedó en segundo lugar");
//        break;
//    case 3:
//        Console.WriteLine("Quedó en tercer lugar");
//        break;
//    case 4:
//        Console.WriteLine("Quedó en cuarto lugar");
//        break;
//    case 5:
//        Console.WriteLine("Quedó en sexto lugar");
//        break;
//    default:
//        Console.WriteLine("Usted no da para eso, 5 lugares y quedaste menos de esos?");
//        break;
//}


//Console.WriteLine("INTRODUCE EL PRIMER NUMERO AUÍ:");
//int num1= int.Parse(Console.ReadLine());

//Console.WriteLine("INTRODUCE EL SEGUNDO NUMERO AQUÍ:");
//int num2 = int.Parse(Console.ReadLine());


//int RESULTADO_SUMA = num1 + num2;
//int RESULTADO_RESTA = num1 - num2;
//int RESULTADO_MULTIPLICACION= num1 * num2;
//int RESULTADO_DIVISION = num1 / num2;

//Console.WriteLine($"LA SUMA DE {num1} y {num2} ES IGUAL A {RESULTADO_SUMA}");
//Console.WriteLine($"LA RESTA DE {num1} y {num2} ES IGUAL A {RESULTADO_RESTA}");
//Console.WriteLine($"LA MULTIPLICACION DE {num1} y {num2} ES IGUAL A {RESULTADO_MULTIPLICACION}");
//Console.WriteLine($"LA DIVISION DE {num1} y {num2} ES IGUAL A {RESULTADO_DIVISION}");


// CALCULADORAAAAAAAAAAAAAAAAAAAAA:

Console.WriteLine("INTRODUCE EL PRIMER NUMERO AUÍ:");
decimal num1 = decimal.Parse(Console.ReadLine());
Console.Clear();

Console.WriteLine("INTRODUCE QUE DESEA HACER AQUÍ:");
Console.WriteLine("1. SUMAR (1)");
Console.WriteLine("2. RESTAR (2)");
Console.WriteLine("3. MULTIPLICAR (3)");
Console.WriteLine("4. DIVIDIR (4)");
string resultado = (Console.ReadLine());
Console.Clear();

Console.WriteLine("INTRODUCE EL SEGUNDO NUMERO AQUÍ:");
decimal num2 = decimal.Parse(Console.ReadLine());
Console.Clear();

switch (resultado)
{

    case "1":
        Console.WriteLine($"{num1 + num2}");
        break;
    case "2":
        Console.WriteLine($"{num1 - num2}");
        break;
    case "3":
        Console.WriteLine($"{num1 * num2}");
        break;
    case "4":
        Console.WriteLine($"{num1 / num2}");
        break;
    default:
        Console.WriteLine("No ha ingresado ninguno de las opciones disponibles, intentelo de nuevo");
        break;
}