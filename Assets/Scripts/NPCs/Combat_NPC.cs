using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat_NPC : MonoBehaviour
{
    public Combat combat;
    public GameObject Akari;
    public ProximityDetector proximitydetector;

    private bool doDamage = false;

    [SerializeField] float Speed;
    [SerializeField] float AttackRange;

    // Start is called before the first frame update
    void Awake()
    {
        combat = Akari.GetComponent<Combat>();
        proximitydetector = GetComponent<ProximityDetector>();
    }

    void NullChecker()
    {
        if (Akari == null)
        return;

        else
        {
            if (proximitydetector.x_difference <= AttackRange && proximitydetector.x_difference >= -AttackRange && proximitydetector.y_difference <= AttackRange && proximitydetector.y_difference >= -AttackRange && !doDamage)
            {
                StartCoroutine(DealDamage());
            }
        }
    }

    public IEnumerator DealDamage()
    {
        doDamage = true;
        yield return new WaitForSeconds(1.0f);
        combat.health.LoseHealth(2.0f);
        doDamage = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (proximitydetector.inRange())
        {
            Vector3 target_pos = combat.transform.position;
            Vector3 Smoothed_Follow = Vector3.Lerp(transform.position, target_pos, Speed * Time.deltaTime);
            transform.position = Smoothed_Follow;
        }

        NullChecker();
    }
}
