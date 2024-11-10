using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UD01
{
    public class Addition : MonoBehaviour
    {
        public int Number = 10;

        void Start()
        {
            int result = 0;
            for (int i = 1; i <= Number; i++) // Se hace un bucle que empieza en uno y termina al alcanzar Number
                result += i;
            Debug.Log(result);
        }
    }
}
