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
    public MasterController movementJoystick;
    public MasterController rotationJoystick;


    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void Update()
    {

        Vector3 moveInput = new Vector3(movementJoystick.Horizontal, movementJoystick.Vertical);
        moveVelocity = moveInput.normalized * speed;

        healthText.text = health.ToString() + "HP";
        if (health <= 0)
        {
            health = 100;
            Debug.Log("You just died ni99a");
        }
    }

    void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + moveVelocity * Time.deltaTime);
        this.transform.Rotate(new Vector3(0, 0, rotationJoystick.Horizontal), speed);
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
