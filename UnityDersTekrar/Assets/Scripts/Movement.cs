using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float RotationSpeed = 10f;
    [SerializeField] private float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {
        float vInput = Input.GetAxis("Vertical");
        float hzInput = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(hzInput, 0.0f, vInput);
        rb.AddForce(move * speed);
    }
}
