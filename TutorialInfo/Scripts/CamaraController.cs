using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 50f;   // Velocidad de movimiento
    public float rotationSpeed = 100f; // Velocidad de rotación

    void Update()
    {
        // Movimiento de la cámara con WASD
        float moveX = Input.GetAxis("Horizontal"); // A y D
        float moveZ = Input.GetAxis("Vertical");   // W y S

        Vector3 move = new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.Self);

        // Rotación de la cámara con flechas izquierda/derecha
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
