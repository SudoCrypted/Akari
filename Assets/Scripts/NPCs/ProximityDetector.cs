using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityDetector : MonoBehaviour
{
    public Transform TargetPlayer;
    public float range;
    public float x_difference;
    public float y_difference;

    public bool inRange()
    {
        x_difference = TargetPlayer.position.x - transform.position.x;
        y_difference = TargetPlayer.position.y - transform.position.y;

        if (x_difference <= range && x_difference >= -range && y_difference <= range && y_difference >= -range)
        return true;

        else
        return false;
    }
}