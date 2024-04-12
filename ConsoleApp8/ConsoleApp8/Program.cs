using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using UnityEngine;

public class EjemploScript : MonoBehaviour
{

    void Awake()
    {
        Debug.Log("Awake() se ha ejecutado.");

        int vida = 100;
        Debug.Log("Vida inicial: " + vida);
    }
    void Start()
    {
        Debug.Log("Start() se ha ejecutado.");

        gameObject.SetActive(true);
    }
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime);
    }
    void FixedUpdate()
    {

        GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Acceleration);
    }
    void OnRenderObject()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    void OnDisable()
    {
        Debug.Log("El objeto se ha desactivado.");
    }
    void OnDestroy()
    {
        Debug.Log("El objeto se ha destruido.");
    }
}
