using UnityEngine;

public class GeneradorDeEsferas : MonoBehaviour
{
    public GameObject objetoEsfera; // Referencia al objeto 3D en la escena
    public float intervaloDeGeneracion = 1f; // Tiempo entre generaciones
    public float fuerzaImpulso = 500f; // Fuerza hacia adelante
    public Vector3 direccionImpulso = Vector3.forward; // Dirección del impulso

    private void Start()
    {
        // Inicia el ciclo de generación de esferas
        InvokeRepeating(nameof(GenerarEsfera), 0f, intervaloDeGeneracion);
    }

    private void GenerarEsfera()
    {
        // Crear una copia del objeto 3D
        GameObject nuevaEsfera = Instantiate(objetoEsfera, transform.position, transform.rotation);

        // Asegúrate de que tenga un Rigidbody
        Rigidbody rb = nuevaEsfera.GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = nuevaEsfera.AddComponent<Rigidbody>();
        }

        // Aplica la fuerza en la dirección indicada
        rb.AddForce(transform.TransformDirection(direccionImpulso) * fuerzaImpulso);
    }
}
