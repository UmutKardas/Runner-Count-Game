using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;
    private Vector3 offset;
    [SerializeField] private float lerpValue;
    private Vector3 newPos;

    void Start()
    {
        offset = transform.position - heroTransform.position;

    }

    void LateUpdate()
    {
        newPos = Vector3.Lerp(transform.position, heroTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPos;

    }
}
