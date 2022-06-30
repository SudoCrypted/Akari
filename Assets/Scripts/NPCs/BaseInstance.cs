using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInstance : MonoBehaviour
{
    public Character Base;
    public Combat combat;
    public ProximityDetector proximitydetector;
    public HealthManager health = new HealthManager();

    public string Type;
    public string Biome;
    public float Health;
    public float rarity;

    public GameObject Self_Base;

    void Awake()
    {
        proximitydetector = GetComponent<ProximityDetector>();
    }

    // Start is called before the first frame update
    public void Start()
    {
        Base = new Character();
        Base.Type = Type;
        Base.Biome = Biome;
        Base.Health = Health;
        Base.rarity = rarity;

        health.MaxHealth = Base.Health;
        health.CurrentHealth = Base.Health;
    }

    // Update is called once per frame
    void Update()
    {
        if (proximitydetector.inRange())
        combat.Target = Self_Base;

        if (health.isDead == true)
        {
            Destroy(gameObject);
            combat.Target = null;
        }
    }
}
