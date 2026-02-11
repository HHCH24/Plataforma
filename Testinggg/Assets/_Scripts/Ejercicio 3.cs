using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    // Creacion variables
    [Header("Persona")]
    public string nombre = "Helen";
    public string apellido = "Chaverra";
    public int a = 5000000;
    public int d = 30;
    public string textName;
    private int result;

    // Start is called before the first frame update
    void Start()
    {
        Salary();
    }

    public void Salary()
    {
        result = a / d;
        //Escribe el resultado en consola
        Debug.Log("La persona " + nombre + apellido + " gana " + result + " en " + 1 + " dias");
        Debug.Log(string.Format("El {0} es {1}", textName, result));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
