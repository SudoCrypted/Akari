using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public BaseInstance baseinstance;
    public GameObject Target;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    void NullChecker()
    {
        if (Target == null)
        return;

        else
        {
            baseinstance = Target.GetComponent<BaseInstance>();
            
            if (baseinstance.proximitydetector.inRange() && Input.GetButtonDown("Fire1"))
            {
                baseinstance.health.LoseHealth(10.0f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        NullChecker();
    }
}
