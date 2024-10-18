using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    void Start()
    {
        for (int i = 2; i <= 100; i++) // Se hace un bucle normal de 0-100
            if (i % 2 == 0 || i % 3 == 0) // En el, se comprueba si el modulo entre 2 o 3 devuelve 0.
                Debug.Log(i); // Si uno de las dos condiciones pasa, es un múltiplo de uno de los dos!
    }
}
