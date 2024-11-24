<h1>Tarea 02</h1>
  <p>Voy a usar el ReadMe como lugar para explicar ciertos detalles del proyecto que están más alla del propio código.</p>
  <p>En primer lugar, la organización de carpetas es ligeramente diferente a la recomendada, 
    decidí separar cada tarea como si fueran "sub-proyectos" dentro del proyecto principal, no solo teniendo todo (scripts, modelos, etc.) 
    dentro de la carpeta de la unidad (UD01, UD02, etc.) si no que los Scripts también usan un Namespace que se llama como la unidad.
    La razón de esto es simplemente por claridad a la hora de escribir código y manejar todo, porque todas las tareas van a estar hechas en un solo proyecto.</p>
  <br>
  <p>Ahora, en cuanto la tarea como tal, hay ciertos detalles que hice en cuanto algunos de los prefabs que no están obviadas en el código:</p>
  <ul>
    <li>Los RigidBodies de los Enemigos y del jugador tienen la rotación bloqueada.</li>
    <li>El jugador usa un "Avatar Mask" para que la animación "Wave" no paralize las piernas mientras el jugador se mueve.</li>
    <li>Los proyectiles usan <i>dos</i> Colliders, uno que es un trigger (y que mata a los enemigos) y otro que es cúbico (para físicas, permitiendo rebotes).</li>
    <li>Decidí unificar los elementos de iluminación entre el mapa del paquete de "Flowers" con la escena de "Egg", por eso la carpeta "Lighting" en Scenes.</li>
  </ul>
