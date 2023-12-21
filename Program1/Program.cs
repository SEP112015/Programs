//Esta variable es inicializada en 1 para asi al momento que el usuario quiera salir del bucle esta se convierta menor que 1
int salir = 1;

do
{
    //Mensaje de bienvenida al usuario
    Console.WriteLine("Bienvenido compai");
    //Aqui se llama la funcion ObtenerOpcionUsuario donde se espera que seleccione una de las 4 opciones.
    string opcion = ObtenerOpcionUsuario();
    Console.Clear();

    //La opcion elegida viaja atraves de esta otra funcion EsOpcionValida donde valida si el usuario eligio una opcion entre 1 - 4.
    if (EsOpcionValida(opcion))
    {
        //Enviamos el primer y segundo numero a la funcion PedirNumero.
        double num1 = PedirNumero("Ingrese el primer número:");
        double num2 = PedirNumero("Ingrese el segundo número:");
        Console.Clear();
        //Luego de que la funcion PedirNumero valide que estos numeros son validos, se envia a la funcion RealizarOperacion donde esta hace las operaciones aritmeticas elegidas.
        RealizarOperacion(opcion, num1, num2);
    }
    else
    {
        //Si el usuario elige una opcion incorrecta diganse fuera del 1-4, el programa arrogará este error.
        MostrarMensajeError("No ha ingresado una opción válida, intentelo de nuevo");
    }
    
    //Luego del programa realizar las operaciones pregunta si desea seguir realizando más, aqui el valor debe ser entre Y para sí o N para no, no importa si el usuario las ingresa en minusculas, la función ToUpper, las pone en 
    //Mayusculas.
    Console.WriteLine("Desea continuar realizando operaciones aritméticas? Y/N");
    string opcionElegidaPorUsuario = Console.ReadLine().ToUpper();
    Console.Clear();

    //Si la respuesta ingresada por el usuario es diferente a Y, entonces el bucle se detiene asigandole a la variable salir (describida al inicio de la aplicacion) un valor negativo, lo cual hace que el bucle se termine.
    if (opcionElegidaPorUsuario != "Y")
    {
        salir = -1;
    }

} while (salir > 0);


//Se obtiene la opcion para realizar la operacion.
static string ObtenerOpcionUsuario()
{
    Console.WriteLine("INTRODUCE QUE DESEA HACER AQUÍ:");
    Console.WriteLine("1. SUMAR (1)");
    Console.WriteLine("2. RESTAR (2)");
    Console.WriteLine("3. MULTIPLICAR (3)");
    Console.WriteLine("4. DIVIDIR (4)");

    return Console.ReadLine();
}

//Se valida el numero ingresado.
static bool EsOpcionValida(string opcion)
{
    return opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4";
}

//Se pide el numero al usuario.
static double PedirNumero(string mensaje)
{
    Console.WriteLine(mensaje);
    string input = Console.ReadLine();

    if (double.TryParse(input, out double numero))
    {
        return numero;
    }
    else
    {
        //Si el numero es incorrecto, digase una letra o caracter, arroja este error.
        MostrarMensajeError("Por favor, ingrese un número válido.");
        return PedirNumero(mensaje);
    }
}

//Se realizan las operaciones.
static void RealizarOperacion(string opcion, double num1, double num2)
{
    switch (opcion)
    {
        case "1":
            MostrarResultado(num1 + num2);
            break;
        case "2":
            MostrarResultado(num1 - num2);
            break;
        case "3":
            MostrarResultado(num1 * num2);
            break;
        case "4":
            if (num2 != 0)
            {
                MostrarResultado(num1 / num2);
            }
            else
            {
                MostrarMensajeError("No es posible dividir por cero.");
            }
            break;
    }
}

//Se muestra el resultado
static void MostrarResultado(double resultado)
{
    Console.WriteLine($"El resultado es: {resultado}");
}

//En caso de error se muestra cual fue.
static void MostrarMensajeError(string mensaje)
{
    Console.WriteLine($"Error: {mensaje}");
}
