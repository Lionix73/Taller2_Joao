using UnityEngine;

public class SingletonExample : MonoBehaviour
{
    // Instancia estática privada de la clase
    private static SingletonExample instance;

    // Propiedad pública estática para acceder a la instancia
    public static SingletonExample Instance
    {
        get
        {
            // Si la instancia no existe, la crea
            if (instance == null)
            {
                instance = FindObjectOfType<SingletonExample>();

                // Si no encuentra una instancia en la escena, crea una nueva
                if (instance == null)
                {
                    GameObject singletonObject = new GameObject(typeof(SingletonExample).Name);
                    instance = singletonObject.AddComponent<SingletonExample>();
                }
            }
            return instance;
        }
    }

    // Método de ejemplo que puede llamar desde cualquier parte del código
    public void ExampleMethod()
    {
        Debug.Log("Ejecutando método de ejemplo.");
    }

    private void Awake()
    {
        // Asegura que solo haya una instancia en la escena
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
