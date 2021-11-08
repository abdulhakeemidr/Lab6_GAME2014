using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [Header("Movement")]
    public float horizontalForce;
    public float verticalForce;

    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        // Keyboard / mouse Input
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");
        float jump = Input.GetAxisRaw("Jump");

        Vector2 worldTouch = new Vector2();

        // Touch Input
        foreach(var touch in Input.touches)
        {
            worldTouch = Camera.main.ScreenToWorldPoint(touch.position);
        }

        var horizontalMoveForce = x * horizontalForce * Time.deltaTime;
        rigidbody.AddForce(Vector2.right * horizontalMoveForce);

        //Debug.Log("X: " + x);
        //Debug.Log("Y: " + y);
        //Debug.Log("Touch: " + worldTouch);
    }

    private void CheckIfGrounded()
    {

    }
}
