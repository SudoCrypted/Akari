using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProprietaryScript : MonoBehaviour
{

    

    ProximityDetector proximitydetector;
    [SerializeField] GameObject NPC;


    // Start is called before the first frame update
    void Awake()
    {
        proximitydetector = GetComponent<ProximityDetector>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
