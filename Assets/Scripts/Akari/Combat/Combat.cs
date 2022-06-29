using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{

    BaseInstance baseinstance;
    [SerializeField] GameObject Target;

    // Start is called before the first frame update
    void Awake()
    {
        baseinstance = Target.GetComponent<BaseInstance>();
    }


    // Update is called once per frame
    void Update()
    {
        if (baseinstance.proximitydetector.inRange() && Input.GetButtonDown("Fire1"))
        {
            baseinstance.health.LoseHealth(10.0f);
        }
    }
}
