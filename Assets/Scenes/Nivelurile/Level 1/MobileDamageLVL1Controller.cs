using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileDamageLVL1Controller : MonoBehaviour
{
    [SerializeField] private float objectDamage; // -1 aici inseamna +1 viata
    [SerializeField] private MobileHealthLVL1Controller healthController; //schimba mereu aici cu lvl la care esti

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Damage();
        }
    }

    void Damage()
    {
        healthController.playerHealth = healthController.playerHealth - objectDamage;
        healthController.UpdateHealth();
        this.gameObject.SetActive(false);
    }
}
