using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityDetector : MonoBehaviour
{
    public bool inRange = false;
    public Transform TargetPlayer;
    public Vector3 Range = new Vector3(2.0f,2.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float x_difference = TargetPlayer.position.x - transform.position.x;
        float y_difference = TargetPlayer.position.y - transform.position.y;

        if (x_difference <= 4.0f && x_difference >= -4.0f && y_difference <= 4.0f && y_difference >= -4.0f)
        {
            inRange = true;
        }
        
        else
        {
            inRange = false;
        }

    }
}
