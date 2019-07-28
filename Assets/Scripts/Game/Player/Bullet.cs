using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 20;
    public Rigidbody rb;

    void Start()
    {        
        rb.velocity = transform.right * speed;
    }
    
    void OnTriggerEnter(Collider col)
    {
        Enemy enemy = col.GetComponent<Enemy>();        
        if (enemy != null)
        {
            enemy.TakeDamage(20);
            Debug.Log("Hit");
        }
        Destroy(gameObject);
    }
}
