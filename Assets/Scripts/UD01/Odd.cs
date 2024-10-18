using UnityEngine;

public class Odd : MonoBehaviour
{
    void Start()
    {
        // Se hace un bucle que empieza en el primer impar, y se le añade 2 en cada bucle (en lugar de 1).
        for (int i = 1; i <= 100; i += 2)
            Debug.Log(i); // De esta manera, los números devueltos son siempre impares.
    }
}
