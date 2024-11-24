using UnityEngine;

namespace UD02 {
    [RequireComponent(typeof(Collider), typeof(Rigidbody))] // Aunque no tienen ninguna lógica de movimiento, el RigidBody estaría si lo hubiera en un juego de verdad.
    public class FlowersEnemy : MonoBehaviour
    {
        /// <summary>
        /// Hace que el enemigo se muera, borrandolo.
        /// </summary>
        public void Kill() { // Aunque este script solo tiene este método para esta tarea, se puede asumir que los enemigos tendrían lógica en un juego de verdad.
            Destroy(gameObject);
        }
    }
}
