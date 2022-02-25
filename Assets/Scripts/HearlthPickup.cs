using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearlthPickup : MonoBehaviour
{
    // Start is called before the first frame update
    public int healAmount;
    public bool isFullHeal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            if (isFullHeal)
            {
                HealthManager.Instance.ResetHealth();
            }
            else
            {
               HealthManager.Instance.AddHealth(healAmount); 
            }
            
        }
    }
}
