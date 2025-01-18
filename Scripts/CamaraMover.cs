using UnityEngine;

public class Camara : MonoBehaviour
{
    private float moveSpeed = 0.1f;        // Velocidad de movimiento


     void Start()
    {
        
    }
    void Update()
    {
        // Movimiento de la cámara con las teclas WASD siempre habilitado
        float horizontal = 0f;
        float vertical = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            vertical = 0.1f;  // Mover hacia adelante
        }
        else if (Input.GetKey(KeyCode.D))
        {
            vertical = -0.1f; // Mover hacia atrás
        }

        if (Input.GetKey(KeyCode.S))
        {
            horizontal = -0.1f;  // Mover hacia la izquierda
        }
        else if (Input.GetKey(KeyCode.W))
        {
            horizontal = 0.1f;   // Mover hacia la derecha
        }

        // Crear el vector de movimiento
        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;

        // Mover la cámara en el espacio global
        transform.Translate(movement, Space.World);
    }
}
