using UnityEngine;

public class Ganador : MonoBehaviour
{
    public AudioSource audioSource;

    // Altura en el eje Y que activará el sonido
    public float triggerHeight = 5.0f;

    // Bandera para verificar si ya se ha reproducido el sonido
    private bool hasPlayed = false;

    void Start()
    {
     
    }

    void Update()
    {
        // Verifica si el objeto ha alcanzado o superado la altura y si el sonido no se ha reproducido aún
        if (transform.position.y >= triggerHeight && !hasPlayed)
        {
            // Reproduce el sonido
            audioSource.Play();
            hasPlayed = true; // Marca el sonido como reproducido
        }
    }
}
