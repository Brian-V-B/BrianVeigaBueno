using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UD02 {
    [RequireComponent(typeof(Rigidbody))] // Fuerza a Unity a añadir un RigidBody2D si no existe.
    public class Egg : MonoBehaviour
    {
        // Este es el multiplicador a la fuerza hacia abajo que el huevo va a tener cuando se instancia.
        [SerializeField] private float _startForce = 2.0f;
        // Si el objeto está debajo de esta altura, es borrado al instante.
        [SerializeField] private float _deleteHeight = -10.0f;


        private void Start() {
            Rigidbody rb = GetComponent<Rigidbody>(); // Se coje el RigidBody2D
            rb.AddForce(Vector3.down * _startForce, ForceMode.VelocityChange); // Cuando se crea, se da una fuerza cara abajo.
        }

        private void FixedUpdate() {
            if (transform.position.y < _deleteHeight)
                Destroy(gameObject); // En cada frame de fisicas, comprobar si está fuera de vista, si lo está, borrar el huevo.
        }
    }
}
