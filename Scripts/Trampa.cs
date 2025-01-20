using UnityEngine;

public class Trampa : MonoBehaviour
{
    // Define la posición de reaparición
    public Vector3 respawnPosition;

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que colisiona es el personaje
        if (other.CompareTag("Camara"))
        {
            // Cambia la posición del personaje a la posición de reaparición
            other.transform.position = respawnPosition;

            // Opcional: Reinicia otras propiedades del personaje si es necesario
            Debug.Log("El personaje ha colisionado con la trampa y ha sido reubicado.");
        }
    }
}
