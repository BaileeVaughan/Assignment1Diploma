using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    private CharacterController charC;

    void Start()
    {
        charC = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        charC.Move(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed * Time.deltaTime);
    }
}
