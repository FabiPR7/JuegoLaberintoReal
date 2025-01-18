using UnityEngine;

public class SistemasPatronnn : MonoBehaviour
{
    public PalancaPatron[] palancas; // Lista de palancas en el orden deseado
    public PalancaPatron.Estado[] patronCorrecto = { PalancaPatron.Estado.Arriba, PalancaPatron.Estado.Arriba, PalancaPatron.Estado.Arriba, PalancaPatron.Estado.Arriba, PalancaPatron.Estado.Arriba }; // El patr�n que debe coincidir
    public PuertaPatron puerta; // Referencia al script de la puerta

    public void VerificarPatron()
    {
        // Verifica si el patr�n actual coincide con el patr�n correcto
        for (int i = 0; i < palancas.Length; i++)
        {
            if (palancas[i].estadoActual != patronCorrecto[i])
            {
                Debug.Log("Patr�n incorrecto.");
                return; // Salir si no coincide
            }
        }

        // Si se lleg� aqu�, el patr�n es correcto
        Debug.Log("�Patr�n correcto! Abriendo puerta...");
        puerta.AbrirPuerta();
    }
}
