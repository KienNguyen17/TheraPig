using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.125f;
    private Vector3 offset = new Vector3(0f, 0f, -15f);
    // private Vector3 velocity = Vector3.zero;


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;

        // Vector3 targetPosition = target.position + offset;
        // transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
