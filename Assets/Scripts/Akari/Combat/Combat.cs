using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Combat : MonoBehaviour
{
    public Character Akari;
    public BaseInstance baseinstance;
    public GameObject Target;
    public HealthManager health = new HealthManager();

    // Start is called before the first frame update
    void Start()
    {
        Akari = new Character();

        Akari.Type = "MC";
        Akari.Biome = "Kingdom";
        Akari.Health = 100.0f;

        health.MaxHealth = Akari.Health;
        health.CurrentHealth = Akari.Health;
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
                baseinstance.health.LoseHealth(2.0f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        NullChecker();

        if (health.isDead == true)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
