using System;

public class Maquina
{
    public string State { get; set; }

    public Maquina(string EstadoInicial)
    {
        State = EstadoInicial;
    }

    public void ImprimirState()
    {
        Console.WriteLine("Estado actual de la máquina expendedora: " + State);
    }

    public void InsertarMoneda()
    {
        if (State == "idle")
        {
            State = "procesando";
            Console.WriteLine("Moneda insertada. Procesando...");
        }
        else
        {
            Console.WriteLine("No se puede insertar una moneda en este momento.");
        }
    }

    public void Dispensar()
    {
        if (State == "procesando")
        {
            State = "idle";
            Console.WriteLine("Artículo dispensado. Máquina lista para próxima transacción.");
        }
        else
        {
            Console.WriteLine("No se puede dispensar un artículo en este momento.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Maquina machine = new Maquina("idle");
        machine.ImprimirState();

        machine.InsertarMoneda();
        machine.ImprimirState();

        machine.Dispensar();
        machine.ImprimirState();
    }
}
