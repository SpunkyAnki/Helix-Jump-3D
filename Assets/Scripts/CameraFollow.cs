using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform TargetToFollow;
    private Vector3 _offset;
    public float CameraSmooth = 0.05f;

    void Start()
    {
        _offset = transform.position - TargetToFollow.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = Vector3.Lerp(transform.position, TargetToFollow.position + _offset, CameraSmooth);
        transform.position = newPosition;
    }
}
