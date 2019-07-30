using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    private Rigidbody rigid;
    private Vector3 moveVelocity;


    void Start()
    {
        rigid = GetComponent<Rigidbody>();

    }
    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        Vector3 moveInput = new Vector3(inputH, inputV);
        moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + moveVelocity * Time.deltaTime);
    }   
}
