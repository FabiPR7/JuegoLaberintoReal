using UnityEngine;

public class PalancaPatron : MonoBehaviour
{
    public enum Estado { Arriba, Abajo }
    public Estado estadoActual = Estado.Abajo; // Estado inicial de la palanca
    public SistemasPatronnn sistemaPatron; // Referencia al sistema de patrón

    private void OnMouseDown()
    {
        // Cambia el estado de la palanca
        estadoActual = estadoActual == Estado.Arriba ? Estado.Abajo : Estado.Arriba;

        // Notifica al sistema de patrón
        if (sistemaPatron != null)
        {
            sistemaPatron.VerificarPatron();
        }

        Debug.Log($"Estado de la palanca {gameObject.name}: {estadoActual}");
    }
}
