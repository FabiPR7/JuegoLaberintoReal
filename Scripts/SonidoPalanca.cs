using UnityEngine;

public class SonidoPalanca : MonoBehaviour
{
    public AudioSource audioSource;
    
    void OnMouseDown()
    {
        // Reproduce el audio solo si no est� sonando
        
            audioSource.Play();
    
    }
}
