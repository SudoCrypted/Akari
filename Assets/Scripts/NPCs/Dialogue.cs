using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    RectTransform recttransform;
    TextMeshPro textmeshpro;
    ProximityDetector proximitydetector;

    [SerializeField] GameObject NPC;

    // Start is called before the first frame update
    void Awake()
    {
        proximitydetector = NPC.GetComponent<ProximityDetector>(); // proximity info
        textmeshpro = GetComponent<TextMeshPro>(); // text access
        recttransform = GetComponent<RectTransform>(); // transform management
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 NPC_Pos = proximitydetector.transform.position; // transform management
        Vector2 Text_Pos = NPC_Pos + new Vector2(0.0f,1.2f); // transform management

        recttransform.anchoredPosition = Text_Pos; // attach text to NPC

        if (proximitydetector.inRange())
        textmeshpro.text = "in range!";

        else
        textmeshpro.text = "";
    }
}
