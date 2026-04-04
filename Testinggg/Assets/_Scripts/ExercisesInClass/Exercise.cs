using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : MonoBehaviour
{
    // Creacion variables
    [Header("Numeros")]
    public int a;
    public int b;
    public string textName;
    private int result;

    // Start is called before the first frame update
    void Start()
    {
        Suma();
    }

    public void Suma()
    {
        result = a+b;
        //Escribe el resultado en consola
        Debug.Log("el resultado es: " + result);
        Debug.Log(string.Format("El {0} es {1}", textName, result));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
