using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityDetector : MonoBehaviour
{
    public Transform TargetPlayer;

    // Start is called before the first frame update
    public void Start()
    {
    }

    public bool inRange()
    {
        float x_difference = TargetPlayer.position.x - transform.position.x;
        float y_difference = TargetPlayer.position.y - transform.position.y;

        if (x_difference <= 4.0f && x_difference >= -4.0f && y_difference <= 4.0f && y_difference >= -4.0f)
        return true;

        else
        return false;
    }

    // Update is called once per frame
    void Update()
    {
    }
}