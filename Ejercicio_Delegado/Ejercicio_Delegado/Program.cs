
//Delegados
/*delegate bool VerificarInput(string inputUsuario);

static bool VerificarInput(string inputUsuario)
{

}*/

//Variables Globales

//Llamado Funciones
TextoUsuario();

void TextoUsuario()
{
    List<int> respuestaUsuario = new List<int>();
    int numeroRespuesta;

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Ingresa una 5 numeros enteros diferentes para un promedio. \n\nNumero #{i + 1}: \n");
        string tempInput = Console.ReadLine();

        if (int.TryParse(tempInput, out numeroRespuesta))
        {
            respuestaUsuario.Add(numeroRespuesta);
            Console.Clear();
        }
        else
        {
            i--;
            Console.Clear();
            Console.WriteLine("Texto Ingresado invalido\n");
        }
    }
}
