using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    new Rigidbody2D rigidbody;
    new Transform transform;

    float speed = 4.0f;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();

        rigidbody.isKinematic = true;
        rigidbody.angularDrag = 0.0f;
        rigidbody.gravityScale = 0.0f;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 AxisControl = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        transform.position += AxisControl * speed * Time.deltaTime;
    }
}
