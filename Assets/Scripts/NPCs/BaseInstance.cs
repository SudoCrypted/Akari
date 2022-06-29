using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInstance : MonoBehaviour
{
    public Character Base;
    public Combat combat;
    public ProximityDetector proximitydetector;
    public HealthManager health = new HealthManager();

    public GameObject Self_Base;

    void Awake()
    {
        proximitydetector = GetComponent<ProximityDetector>();
    }

    // Start is called before the first frame update
    public void Start()
    {
        Base = new Character();
        Base.Type = "Base";
        Base.Biome = "Winter";
        Base.Health = 100.0f;
        Base.rarity = 0.6f;

        health.MaxHealth = Base.Health;
        health.CurrentHealth = Base.Health;
    }

    // Update is called once per frame
    void Update()
    {
        if (proximitydetector.inRange())
        combat.Target = Self_Base;
    }
}
