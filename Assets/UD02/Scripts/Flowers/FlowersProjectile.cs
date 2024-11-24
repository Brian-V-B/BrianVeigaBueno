using UnityEngine;

namespace UD02 {
    [RequireComponent(typeof(Collider), typeof(Rigidbody))] // Necesita al menos un Collider para poder funcionar, además del RigidBody.
    public class FlowersProjectile : MonoBehaviour
    {
        private float _time = 0.0f; // Este valor tendra cuanto tiempo lleva existiendo el proyectil, en segundos.
        private void Update() {
            // Esto es una lógica simple que destruye los proyectiles después de 15 segundos. Para conservar recursos.
            _time += Time.deltaTime; // Se añade el delta a _time, delta siempre siendo los milisegundos entre frames.
            if (_time > 15.0f) // Cuando el tiempo supera 15 segundos, se borra el proyectil.
                Destroy(gameObject);
        }


        // Se hace OnTriggerEnter porque así se pueden tener dos Colliders:
        //      Uno para detectar los enemigos - que es le que activa este método,
        //      Y otro que permite añadir comportamiento de físicas en el proyectil.
        private void OnTriggerEnter(Collider other) {
            if (other.TryGetComponent(out FlowersEnemy enemy)) { // En lugar de comprobar por tag, se puede preguntar si tiene el componente.
                enemy.Kill(); // De esa manera, se puede llamar el método del script directamente.
                Destroy(gameObject); // También se destruye el proyectil.
            }
        }
    }
}
