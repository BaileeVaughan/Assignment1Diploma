using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public int health = 100;
    private Vector3 moveVelocity;
    public Text healthText;
    private Rigidbody rigid;
    public Enemy enemy;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");
        Vector3 moveInput = new Vector3(inputH, inputV);
        moveVelocity = moveInput.normalized * speed;

        healthText.text = health.ToString();
        if (health <= 0)
        {
            health = 100;
            Debug.Log("You just died ni99a");
        }
    }

    void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + moveVelocity * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Enemy"))
        {
            health -= enemy.enemyDamage;
            Debug.Log("We have been hit");
        }
    }  
}
