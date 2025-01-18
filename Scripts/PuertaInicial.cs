using UnityEngine;
using System.Collections;

public class puertaFisica : MonoBehaviour
{
    public Vector3 desplazamientoApertura = new Vector3(0, 1, 0);  // Desplazamiento de la puerta al abrirse
    public float tiempoApertura = 0.5f;  // Duraci�n m�s r�pida de la animaci�n de apertura o cierre

    private Vector3 posicionInicial;  // Posici�n inicial de la puerta
    private Vector3 posicionAbierta;  // Posici�n abierta calculada a partir del desplazamiento
    private bool estaAbierta = false;  // Estado de la puerta (abierta o cerrada)

    void Start()
    {
        // Configura las posiciones inicial y abierta
        posicionInicial = transform.position;
        posicionAbierta = posicionInicial + desplazamientoApertura;

        // Inicia la animaci�n repetitiva
        InvokeRepeating("AbrirCerrar", 0f, tiempoApertura * 2); // Alterna cada tiempoApertura * 2 segundos
    }

    void AbrirCerrar()
    {
        // Alterna el estado de la puerta y llama a la animaci�n correspondiente
        if (estaAbierta)
        {
            StopAllCoroutines();
            StartCoroutine(MoverPuerta(posicionAbierta, posicionInicial));
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(MoverPuerta(posicionInicial, posicionAbierta));
        }

        estaAbierta = !estaAbierta; // Cambia el estado
    }

    IEnumerator MoverPuerta(Vector3 inicio, Vector3 fin)
    {
        float tiempoTranscurrido = 0f;

        while (tiempoTranscurrido < tiempoApertura)
        {
            // Interpolaci�n lineal entre las posiciones de inicio y fin
            transform.position = Vector3.Lerp(inicio, fin, tiempoTranscurrido / tiempoApertura);
            tiempoTranscurrido += Time.deltaTime;
            yield return null; // Espera hasta el siguiente frame
        }

        // Asegura que la puerta termine exactamente en la posici�n final
        transform.position = fin;
    }
}
