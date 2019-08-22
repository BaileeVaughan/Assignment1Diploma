using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shotOrigin;

    public void Shoot()
    {
        Instantiate(bulletPrefab, shotOrigin.position, shotOrigin.rotation);        
    }
}
