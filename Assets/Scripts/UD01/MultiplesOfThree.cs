using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    void Start()
    {
        for (int i = 3; i <= 100; i += 3) // Similar a Even y Odd, excepto que se suma 3 a cada paso.
            Debug.Log(i);
    }
}
