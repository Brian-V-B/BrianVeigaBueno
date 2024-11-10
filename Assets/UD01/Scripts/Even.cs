using UnityEngine;

namespace UD01
{
    public class Even : MonoBehaviour
    {
        void Start()
        {
            // Se hace un bucle que empieza en 0, y se le añade 2 en cada bucle (en lugar de 1).
            for (int i = 0; i <= 100; i += 2)
                Debug.Log(i); // De esta manera, los números devueltos son siempre pares.
        }
    }
}
