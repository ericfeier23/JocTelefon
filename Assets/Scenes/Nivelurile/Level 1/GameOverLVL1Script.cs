using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverLVL1Script : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void PlayerPage()
    {
        SceneManager.LoadScene("PlayerPage");
    }  
}
