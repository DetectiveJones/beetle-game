using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

   // public Animator animator;

    public void WinLevel()
    {
        Debug.Log("Level won!");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        // animator.SetTrigger("EndGame");
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
        }
    }

    public void RestartLevel()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score.instance.ResetScore();
    }

}
