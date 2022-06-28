using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public float HealthAmount = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(HealthAmount <= 0.0f)
        DeathSequence();

        if(Input.GetKeyDown(KeyCode.E))
        {
            DamageTaken(10.0f);
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            HealingSequence(10.0f);
        }
    }

    public void DeathSequence()
    {
        Debug.Log("Player Death.");
    }

    public float DamageTaken(float Damage)
    {
        HealthAmount -= Damage;
        healthBar.fillAmount = HealthAmount / 100;

        return HealthAmount;
    }

    public float HealingSequence(float Healing)
    {
        HealthAmount += Healing;
        HealthAmount = Mathf.Clamp(HealthAmount, 0, 100);
        healthBar.fillAmount = HealthAmount / 100;

        return HealthAmount;
    }
}
