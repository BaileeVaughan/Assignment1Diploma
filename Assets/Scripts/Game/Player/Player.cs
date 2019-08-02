using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public int health = 100;
    private Rigidbody rigid;
    private Vector3 moveVelocity;
    public bool enter = true;



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
    private void OnTriggerEnter(Collider other)
    {
        //health -= enemy.damage;
        if (enter)
        {   
            Debug.Log("We have been hit");
        }
    }
  
}
