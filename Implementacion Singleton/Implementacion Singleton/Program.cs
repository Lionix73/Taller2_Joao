public class Singleton
{
    private static Singleton instance;
    private static readonly object lockObject = new object();

    private Singleton()
    {
        // Constructor 
    }

    public static Singleton Instance
    {
        get
        {
            // doble bloqueo de seguridad para garantizar que no sea nulo
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }

    // Métodos de la instancia del Singleton
    public void SomeMethod()
    {
        // Implementación
    }
}