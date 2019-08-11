using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shotOrigin;
   
    //private void Update()
    //{
    //    if (Input.GetButtonDown("Fire1"))
    //    {
    //        Shoot();
    //        Debug.Log("Shot");
    //    }
    //}

    public void Shoot()
    {
        Instantiate(bulletPrefab, shotOrigin.position, shotOrigin.rotation);        
    }
}
