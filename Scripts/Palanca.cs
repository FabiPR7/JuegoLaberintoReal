using UnityEngine;

public class Palanca : MonoBehaviour
{
    public Puerta puerta; // Referencia al script Puerta
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnMouseDown()
    {
        if (puerta != null)
        {
            puerta.AbrirPuerta();
        }
        else
        {
            Debug.LogError("No se asign� una puerta al script JalarPalanca.");
        }
    }
}
