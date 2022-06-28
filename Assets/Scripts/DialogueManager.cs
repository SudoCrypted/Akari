using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    Dialogue dialogue;
    RectTransform recttransform;
    ProximityDetector proximitydetector;
    [SerializeField] GameObject NPC;

    // Start is called before the first frame update
    void Awake()
    {
        dialogue = NPC.GetComponent<Dialogue>();
        proximitydetector = NPC.GetComponent<ProximityDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 NPC_Pos = dialogue.transform.position; // transform management
        Vector2 Text_Pos = NPC_Pos + new Vector2(0.0f,2.0f); // transform management

        recttransform = GetComponent<RectTransform>(); // transformmanagement

        if (proximitydetector.inRange())
        {
        }

        Debug.Log(proximitydetector.inRange());
    }
}
