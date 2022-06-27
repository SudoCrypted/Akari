using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    new Rigidbody2D rigidbody;
    public float speed = 1000.0f;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.isKinematic = false;
        rigidbody.angularDrag = 0.0f;
        rigidbody.gravityScale = 0.0f;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    void Move(Vector2 targetVelocity)
    {
        rigidbody.velocity = (targetVelocity * speed) * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 AxisControl = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Move(AxisControl);
    }
}
