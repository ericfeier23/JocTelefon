using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Pass();
            SceneManager.LoadScene("Level 1Death");
        }
    }
    public void Pass()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex ;

        if (currentLevel >= PlayerPrefs.GetInt("levelsUnlocked"))
        {
            PlayerPrefs.SetInt("levelsUnlocked", currentLevel + 1);
        }
        Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelsUnlocked") + "Unlocked");
    }
}
