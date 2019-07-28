using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderKill : MonoBehaviour
{
    public GameObject bulletPrefab;

    public void OnTriggerEnter(Collider col)
    {
        if (col == bulletPrefab)
        {
            Destroy(col);
        }
    }
}
