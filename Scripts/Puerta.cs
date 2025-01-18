using UnityEngine;

public class Puerta : MonoBehaviour
{

    private bool abierta = false;
    public float alturaApertura = 3f; // Cuánto se moverá hacia arriba
    public float velocidad = 2f; // Velocidad de apertura
    private Vector3 posicionInicial;
    private Vector3 posicionFinal;

    private void Start()
    {
        // Guardamos la posición inicial y calculamos la posición final
        posicionInicial = transform.position;
        posicionFinal = posicionInicial + new Vector3(0, alturaApertura, 0);
    }

    public void AbrirPuerta()
    {
        if (!abierta)
        {
            abierta = true;
            StartCoroutine(MoverPuerta(posicionFinal)); // Llamamos a la corrutina para mover
        }
        else
        {
            Debug.Log("La puerta ya está abierta.");
        }
    }

    private System.Collections.IEnumerator MoverPuerta(Vector3 destino)
    {
        while (Vector3.Distance(transform.position, destino) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, destino, velocidad * Time.deltaTime);
            yield return null; // Esperar un frame
        }

        transform.position = destino; // Aseguramos que llega al destino exacto
    }
}
