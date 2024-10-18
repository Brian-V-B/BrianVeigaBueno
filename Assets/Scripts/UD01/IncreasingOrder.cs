using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    public int NumberA = 4;
    public int NumberB = 9;
    public int NumberC = 14;


    void Start()
    {
        // Se hace una simple comparación, si A < B < C, entonces el orden es el querido. Aunque también se llama si son iguales.
        if (NumberA <= NumberB && NumberB <= NumberC)
            Debug.Log("Los números están en un orden creciente!");
        else
            Debug.Log("Los números no están en un orden creciente");
    }
}
