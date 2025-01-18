using UnityEngine;

public class MoverEsfera : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad constante hacia adelante
    public float tiempoDeVida = 5f; // Tiempo en segundos antes de desaparecer

    private void Start()
    {
        // Destruir el objeto después del tiempo especificado
        Destroy(gameObject, tiempoDeVida);
    }

    private void Update()
    {
        // Mover la esfera hacia adelante continuamente
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}
