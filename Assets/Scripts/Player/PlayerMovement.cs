using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector2 movedirection;
    [SerializeField] float MoveSpeed = 10;
    private Rigidbody2D MyRigidBody;

    private void Awake()
    {
        MyRigidBody = GetComponent<Rigidbody2D>();
    }
    private void OnMove(InputValue value)
    {
        if (value != null)
        {
            movedirection = value.Get<Vector2>();
        }
        
    }

    void Walk()
    {
        MyRigidBody.velocity = movedirection * MoveSpeed * Time.deltaTime;
    }

    private void Update()
    {
        Walk();-
    }
}
