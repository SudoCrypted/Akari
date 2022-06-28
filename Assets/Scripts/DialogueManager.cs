using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    Dialogue dialogue;
    RectTransform recttransform;
    TextMeshPro textmeshpro;
    ProximityDetector proximitydetector;
    [SerializeField] GameObject NPC;

    // Start is called before the first frame update
    void Awake()
    {
        dialogue = NPC.GetComponent<Dialogue>();
        proximitydetector = NPC.GetComponent<ProximityDetector>();
        textmeshpro = GetComponent<TextMeshPro>();
        recttransform = GetComponent<RectTransform>(); // transformmanagement
    }

    void FixedUpdate()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 NPC_Pos = dialogue.transform.position; // transform management
        Vector2 Text_Pos = NPC_Pos + new Vector2(0.0f,1.2f); // transform management

        recttransform.anchoredPosition = Text_Pos;

        if (proximitydetector.inRange())
        {
            textmeshpro.text = "Hi.";
        }
    }
}
