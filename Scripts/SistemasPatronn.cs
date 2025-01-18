using UnityEngine;

public class SistemasPatronnn : MonoBehaviour
{
    public PalancaPatron[] palancas; // Lista de palancas en el orden deseado
    public PalancaPatron.Estado[] patronCorrecto = { PalancaPatron.Estado.Arriba, PalancaPatron.Estado.Arriba, PalancaPatron.Estado.Arriba, PalancaPatron.Estado.Arriba, PalancaPatron.Estado.Arriba }; // El patrón que debe coincidir
    public PuertaPatron puerta; // Referencia al script de la puerta

    public void VerificarPatron()
    {
        // Verifica si el patrón actual coincide con el patrón correcto
        for (int i = 0; i < palancas.Length; i++)
        {
            if (palancas[i].estadoActual != patronCorrecto[i])
            {
                Debug.Log("Patrón incorrecto.");
                return; // Salir si no coincide
            }
        }

        // Si se llegó aquí, el patrón es correcto
        Debug.Log("¡Patrón correcto! Abriendo puerta...");
        puerta.AbrirPuerta();
    }
}
