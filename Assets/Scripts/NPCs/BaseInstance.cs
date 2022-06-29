using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInstance : MonoBehaviour
{

    public Character Base; 

    // Start is called before the first frame update
    void Start()
    {
        Base = new Character();
        Base.Type = "Base";
        Base.Biome = "Winter";
        Base.Health = 100.0f;
        Base.rarity = 0.6f;

        HealthManager health = new HealthManager();
        health.MaxHealth = Base.Health;
        health.CurrentHealth = Base.Health;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
