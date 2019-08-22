using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;
    public int bulletDamage = 20;

    void Start()
    {        
        rb.velocity = transform.forward * speed;
    }
    
    void OnTriggerEnter(Collider col)
    {
        Enemy enemy = col.GetComponent<Enemy>();        
        if (enemy != null)
        {
            enemy.TakeDamage(bulletDamage);
            Debug.Log("Hit");
        }
        Destroy(gameObject);
    }
}
