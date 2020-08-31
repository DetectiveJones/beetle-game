using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

   // public Animator animator;

    public void EndGame()
    {
       // animator.SetTrigger("EndGame");
    }

    public void RestartLevel()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score.instance.ResetScore();
    }

}
