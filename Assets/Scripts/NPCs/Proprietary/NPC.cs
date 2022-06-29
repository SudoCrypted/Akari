using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    BaseInstance baseinstance;
    public GameObject Self;

    // Start is called before the first frame update
    void Awake()
    {
        baseinstance = GetComponent<BaseInstance>();
    }

    // Update is called once per frame
    void Update()
    {
        if (baseinstance.proximitydetector.inRange())
        {
            baseinstance.Target = Self;
        }
    }
}
