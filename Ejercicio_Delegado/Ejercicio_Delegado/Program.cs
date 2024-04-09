#region Variables
//Variables Globales
VerificarInput VerificarI = VerificarInput;
#endregion

//Llamado Funciones
TextoUsuario();

#region Funciones

//Funciones
void TextoUsuario()
{
    List<int?> respuestaUsuario = new List<int?>();
    int? numeroRespuesta;

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Ingresa una 5 numeros enteros diferentes para un promedio. \n\nNumero #{i + 1}: \n");
        string tempInput = Console.ReadLine();

        numeroRespuesta = VerificarI(tempInput);

        if (numeroRespuesta != null)
        {
            Console.Clear();
            respuestaUsuario.Add(numeroRespuesta);

            
        }
        else
        {
            i--;
            Console.Clear();
            Console.WriteLine("Texto Ingresado invalido\n");
        }
    }

    int? prom = CalcularPromedio(respuestaUsuario);

    MostrarPromedio(prom);
    MostrarNumeros(respuestaUsuario);
}

int? CalcularPromedio(List<int?> respuestaUsuario)
{
    int? suma = 0;
    int i = 0;

    foreach (int? numberTemp in respuestaUsuario)
    {
        suma = suma + numberTemp;
        i++;
    }

    return suma / i;
}

void MostrarPromedio(int? prom)
{
    Console.Clear ();
    Console.WriteLine($"El promedio de tus numeros es: {prom} \n");
}

void MostrarNumeros(List<int?> respuestaUsuario)
{
    Console.WriteLine("Tus numeros son: \n");

    foreach (int? numero in respuestaUsuario)
    {
        Console.Write($"{numero}\t");
    }

    Console.WriteLine("\n------------------------------");
}

#endregion

#region Delegado

//Delegado
static int? VerificarInput(string inputUsuario)
{
    int inputCorrecto;
    if (int.TryParse(inputUsuario, out inputCorrecto))
    {
        return inputCorrecto;
    }
    else
    {
        return null;
    }
}

delegate int? VerificarInput(string inputUsuario);

#endregion
