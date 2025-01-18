using UnityEngine;

public class PuertaPatron : MonoBehaviour
{
    private bool abierta = false;
    public float alturaApertura = 3f;
    public float velocidad = 2f;

    private Vector3 posicionInicial;
    private Vector3 posicionFinal;

    private void Start()
    {
        posicionInicial = transform.position;
        posicionFinal = posicionInicial + new Vector3(0, alturaApertura, 0);
    }

    public void AbrirPuerta()
    {
        if (!abierta)
        {
            abierta = true;
            StartCoroutine(MoverPuerta(posicionFinal));
        }
    }

    private System.Collections.IEnumerator MoverPuerta(Vector3 destino)
    {
        while (Vector3.Distance(transform.position, destino) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, destino, velocidad * Time.deltaTime);
            yield return null;
        }
        transform.position = destino;
    }
}
