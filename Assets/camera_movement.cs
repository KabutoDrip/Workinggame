using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public Transform targetObject;

    public Vector3 cameraOffset;

    void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = targetObject.transform.position + cameraOffset;
        transform.position = newPosition;
    }
}
