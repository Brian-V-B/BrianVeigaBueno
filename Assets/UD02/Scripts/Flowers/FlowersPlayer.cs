using UnityEngine;

namespace UD02 {
    [RequireComponent(typeof(Collider), typeof(Rigidbody), typeof(Animator))] // Se pone como obligatorio todos los componentes necesarios para funcionamiento.
    public class FlowersPlayer : MonoBehaviour
    {
        // Constantes
        private const float _groundTolerance = 0.1f; // Una constante, que es la distancia máxima que se comprueba si se está en el suelo o no.


        // Variables Públicas
        public bool IsGrounded {get; private set;} // Se puede acceder públicamente si está en el suelo, pero solo el script local puede manejarlo.


        // Proyectiles
        [SerializeField] private float _projectileLaunchPower = 10f; // La fuerza inicial que el proyectil va a tener. (Es manejado por físicas)
        [SerializeField] private FlowersProjectile _projectile; // La referencia del Prefab del proyectil.
        [SerializeField] private Transform _fireLocation; // El transform de donde saldrá el proyectil, esta vez, es obligatorio definirlo.


        [SerializeField] private float _moveSpeed = 15.0f; // La velocidad de movimiento que es usada como referencia.
        [SerializeField] private float _jumpPower = 6.0f; // La fuerza que el jugador recibe al saltar.


        // Componentes
        private Rigidbody rigidBody;
        private Animator animator;


        private void Start() {
            // Guardamos la referencia de los componentes, para usarlos más fácilmente.
            rigidBody = GetComponent<Rigidbody>();
            animator = GetComponent<Animator>();
        }

        private void Update() {
            GroundCheck(); // Se hace la comprobación de si el personaje está en el suelo.

            Movement(); // Se llama la lógica de movimiento por cada Update.

            AttackBehaviour(); // Al final, se comprueba la lógica de ataque.
        }


        /// <summary>
        /// La lógica de movimiento, se llama una vez en Update.
        /// </summary>
        private void Movement() {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * _moveSpeed; // Se guarda el vector de movimiento en una variable.
            transform.LookAt(transform.position + movement); // Se hace que el personaje mire a donde se mueve.
            transform.Translate(movement * Time.deltaTime, Space.World); // Se aplica el movimiento en el translate, multiplicandolo por la velocidad de movimiento y el delta.
            
            if (Input.GetButtonDown("Jump") && IsGrounded)
                Jump(); // Se salta si se puede saltar.
            
            animator.SetFloat("MoveSpeed", movement.magnitude / _moveSpeed); // Se pone el valor de movimiento en el Animator.
        }

        /// <summary>
        /// Llamado en cada frame, comprueba los inputs y maneja la lógica de ataque.
        /// </summary>
        private void AttackBehaviour() {
            if (_projectile != null && Input.GetButtonDown("Fire1")) { // Null check y check de input.
                animator.SetTrigger("Attack"); // Se activa el estado de atacar.
                FlowersProjectile p = Instantiate(_projectile, _fireLocation.position, _fireLocation.rotation); // Se instancia el proyectil y se guarda.
                p.GetComponent<Rigidbody>().AddForce(p.transform.forward * _projectileLaunchPower, ForceMode.VelocityChange); // Se coje el RigidBody del proyectil y se le dá una fuerza.
            }
        }

        /// <summary>
        /// Cuando se llama, aplica jumpPower sobre el jugador.
        /// </summary>
        private void Jump() {
            rigidBody.AddForce(Vector3.up * _jumpPower, ForceMode.VelocityChange); // Se aplica la fuerza verticalmente, nada especial.
            animator.SetTrigger("Jump"); // Se activa la animación de saltar.
        }


        /// <summary>
        /// Llamado al principio de Update, hace un Raycast y pone el valor a IsGrounded.
        /// </summary>
        private void GroundCheck() {
            IsGrounded = Physics.Raycast(transform.position, Vector3.down, _groundTolerance); // Se hace un Raycast y se guarda su valor en IsGrounded.
            animator.SetBool("Grounded", IsGrounded); // Se guarda el estado en el Animator.
        }
    }

}
