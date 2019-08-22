using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = .15f;
    public float minXPos = 0, maxXPos = 0, minYPos = 0, maxYPos = 0;
    public bool bounds;

    Vector3 velocity = Vector3.zero;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        Vector3 targetPosition = target.transform.position;

        if (bounds == true)
        {
            targetPosition.y = Mathf.Clamp(target.transform.position.y, minYPos, maxYPos);
            targetPosition.x = Mathf.Clamp(target.transform.position.x, minXPos, maxXPos);
        }

        targetPosition.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
