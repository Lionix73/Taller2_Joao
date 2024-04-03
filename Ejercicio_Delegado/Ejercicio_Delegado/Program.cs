//Variables Globales
VerificarInput VerificarI = VerificarInput;

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
}

int? CalcularPromedio(List<int?> respuestaUsuario)
{
    int? suma = 0;
    int i = 0;
    int? prom;

    foreach (int? numberTemp in respuestaUsuario)
    {
        suma =+ numberTemp;
        i++;
    }

    return prom = suma / i;
}

#endregion

#region Delegado

//Delegados
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
