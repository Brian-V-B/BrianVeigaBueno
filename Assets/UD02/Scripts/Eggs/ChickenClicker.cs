using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UD02 {
    public class ChickenClicker : MonoBehaviour
    {
        // El prefabricado que se va a instanciar.
        [SerializeField] private GameObject eggPrefab;
        // El transform que es usado como referencia para donde instanciar el objeto.
        [SerializeField] private Transform instancerTransform;


        private void FixedUpdate() {
            transform.position = new Vector3(Mathf.Sin(Time.fixedTime) * 5, Mathf.Sin(Time.fixedTime / 2) * 3.33f, 0); // Se hace que la gallina se mueva por la pantalla con un patron ciclico.
        }

        private void OnMouseDown() {
            if (Input.GetMouseButtonDown(0) && eggPrefab != null) { // Ademas de comprobar que es el click derecho, se hace un check por Nulls por si acaso.
                Transform t = instancerTransform != null ? instancerTransform : transform; // Como un detalle extra, se comprueba si instancerTransform es null, si lo es, se usa el Transform del objeto.
                Instantiate(eggPrefab, t.position, t.rotation); // Finalmente, se instancia el huevo, con la posición de este estando en el transform seleccionado.
            }
        }
    }
}
