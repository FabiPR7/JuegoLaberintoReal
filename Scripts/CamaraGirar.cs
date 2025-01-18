using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 10f;        // Velocidad de movimiento
    public float lookSpeed = 3f;         // Sensibilidad de rotación del ratón
    public float salto = 0.1f;
    private float rotationX = 0f;        // Rotación en el eje X (vertical)
    private float rotationY = 0f;
    private int contadoraArriba = 0;// Rotación en el eje Y (horizontal)
    // Almacenamos la posición inicial del ratón
    private int contadoraAbajo = 0;
    private Vector3 initialMousePosition;
    private bool estaEnElSuelo = true;  // Bandera para saber si el objeto está tocando el suelo
    private bool salta = false;

    void Start()
    {
        // Guardamos la posición inicial del ratón en el inicio
        initialMousePosition = Input.mousePosition;
    }

    void Update()
    {   
        // Movimiento con WASD (teclas W, A, S, D)
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && estaEnElSuelo)
        {
            salta = true;
            Debug.Log("¡Se presionó la tecla Space!");
                       
        }
        if (salta)
        {
            if (contadoraArriba <= 5)
            {
                transform.position += new Vector3(0, salto, 0);
               
                contadoraArriba = contadoraArriba + 1;
            }
            else {
                    salta = false;
                    contadoraAbajo = 0;
                    contadoraArriba = 0;
                salto = 0.1f;
            }

        }
   
       
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        transform.Translate(movement, Space.Self); // Movimiento de la cámara en el espacio local

        // Rotación solo cuando el botón derecho del ratón está presionado
        if (Input.GetMouseButton(1)) // 1 es el botón derecho del ratón
        {
            // Obtener el movimiento del ratón
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            // Rotación horizontal (eje Y) - girar la cámara en el plano horizontal
            rotationY += mouseX * lookSpeed;

            // Rotación vertical (eje X) - girar la cámara en el plano vertical
            rotationX -= mouseY * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, 0f, 0f); // Limitar la rotación para evitar que se voltee completamente

            // Aplicar las rotaciones a la cámara
            transform.rotation = Quaternion.Euler(rotationX, rotationY, 0f);
        }
    }
    // Detecta si el objeto está tocando el suelo (en este caso, usando OnCollisionEnter)
    private void OnCollisionEnter(Collision collision)
    {
        // Comprobamos si el objeto con el que colisionamos es el suelo (puedes usar un tag o nombre específico)
        if (collision.gameObject.CompareTag("Suelo"))
        {
            estaEnElSuelo = true;
        }
    }

    // Opcional: Detectar si deja de tocar el suelo
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            estaEnElSuelo = false;
        }
    }
}
