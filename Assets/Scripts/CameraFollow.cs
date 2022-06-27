using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour

{

    public Transform target;
    public Vector3 offset;
    public float FollowSpeed;

    // Update is called once per frame
    void LateUpdate()
    {
        SmoothFollow();
    }

    void SmoothFollow()
    {
        Vector3 TargetPosition = target.position + offset;
        Vector3 SmoothedFollow = Vector3.Lerp(transform.position, TargetPosition, FollowSpeed * Time.smoothDeltaTime);
        transform.position = SmoothedFollow;
    }
}
