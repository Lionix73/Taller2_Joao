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

#endregion

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
