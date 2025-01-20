using UnityEngine;

public class Trampa : MonoBehaviour
{
    // Define la posici�n de reaparici�n
    public Vector3 respawnPosition;

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que colisiona es el personaje
        if (other.CompareTag("Camara"))
        {
            // Cambia la posici�n del personaje a la posici�n de reaparici�n
            other.transform.position = respawnPosition;

            // Opcional: Reinicia otras propiedades del personaje si es necesario
            Debug.Log("El personaje ha colisionado con la trampa y ha sido reubicado.");
        }
    }
}
