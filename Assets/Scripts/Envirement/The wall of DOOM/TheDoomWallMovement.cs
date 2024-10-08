using UnityEngine;
using UnityEngine.EventSystems;

public class TheDoomWallMovement : MonoBehaviour
 {
    [SerializeField] float MoveSpeed = 1000f;
    [SerializeField] private Rigidbody2D RB2 = new Rigidbody2D();
    Vector2 movedirection = Vector2.right;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RB2.linearVelocityX = movedirection.x * MoveSpeed * Time.deltaTime;
    }
}
