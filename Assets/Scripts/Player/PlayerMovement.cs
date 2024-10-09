using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Lumin;

public class PlayerMovement : MonoBehaviour
{
    Vector2 movedirection;
    [SerializeField] float MoveSpeed = 700;
    private Rigidbody2D MyRigidBody;
    [SerializeField] private SpriteRenderer SR;
    [SerializeField] float Jumpforce = 600;
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

    private void Onjump(InputValue value)
    {
        if (value !=null)
        {
            Jumpforce = value.Get<float>();
        }
    }

    void Walk()
    {
        //MyRigidBody.linearVelocity = movedirection * MoveSpeed * Time.deltaTime;
        MyRigidBody.linearVelocityX = movedirection.x * MoveSpeed * Time.deltaTime;

        if (MyRigidBody.linearVelocityX < 0)
        {
            SR.flipX = false;
        }
        if (MyRigidBody.linearVelocityX > 0)
        {
            SR.flipX = true;
        }
    }

    void Jump()
    {

        if (Input.GetButtonDown("Jump") && MyRigidBody.linearVelocityY == 0 )
        {
            MyRigidBody.linearVelocityY = Jumpforce * Time.deltaTime;
        }
    }

    private void Update()
    {
        Walk();
        Jump();
    }
}
