using UnityEngine;

using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private Vector2 direction;
    public float velocidad;
    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        //Movimiento
        _compRigidbody2D.velocity = new Vector2(direction.x * velocidad, direction.y * velocidad);
    }
    public void Movement(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
}
