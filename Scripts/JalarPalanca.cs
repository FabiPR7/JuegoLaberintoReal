using System.Threading;
using UnityEngine;


public class LeverClickDetector : MonoBehaviour
{
    private bool enPosicionInicial = true; // Estado de la palanca
    public Vector3 rotacionInicial = new Vector3(32.56f, 0, 0); // Rotaci�n inicial
    public Vector3 rotacionFinal = new Vector3(-52.2f, 0, 0);   // Rotaci�n final

    private void OnMouseDown()
    {
        if (enPosicionInicial)
        {
            // Cambiar a la rotaci�n final
            transform.eulerAngles = rotacionFinal;
        }
        else
        {
            // Cambiar a la rotaci�n inicial
            transform.eulerAngles = rotacionInicial;
        }

        enPosicionInicial = !enPosicionInicial; // Alternar estado
        print($"PALANCA CLICKEADA: Nueva posici�n -> {transform.eulerAngles}");
    }
}

