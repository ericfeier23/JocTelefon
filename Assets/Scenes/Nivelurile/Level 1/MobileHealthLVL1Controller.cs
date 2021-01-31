using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MobileHealthLVL1Controller : MonoBehaviour
{
    public float playerHealth;
    [SerializeField] private Text healthText;

    public void UpdateHealth()
    {
        healthText.text = playerHealth.ToString("0");

        if(playerHealth < 0)
        {
            SceneManager.LoadScene("Level 1Death");
        }
    }
}
