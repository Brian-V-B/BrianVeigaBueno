using UnityEngine;

namespace UD01
{
    public class DescendingOrder : MonoBehaviour
    {
        public int NumberA = 7;
        public int NumberB = 5;
        public int NumberC = -2;


        void Start()
        {
            // Se hace una simple comparación, si A > B > C, entonces el orden es el querido. Aunque también se llama si son iguales.
            if (NumberA >= NumberB && NumberB >= NumberC) 
                Debug.Log("Los números están en un orden descendiente!");
            else
                Debug.Log("Los números no están en un orden descendiente");
        }
    }
}
