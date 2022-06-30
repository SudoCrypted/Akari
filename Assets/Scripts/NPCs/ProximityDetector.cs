using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityDetector : MonoBehaviour
{
    public Transform TargetPlayer;
    public float range;

    public bool inRange()
    {
        float x_difference = TargetPlayer.position.x - transform.position.x;
        float y_difference = TargetPlayer.position.y - transform.position.y;

        if (x_difference <= range && x_difference >= -range && y_difference <= range && y_difference >= -range)
        return true;

        else
        return false;
    }
}