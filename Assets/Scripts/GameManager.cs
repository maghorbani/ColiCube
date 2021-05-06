using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    [SerializeField] private GameObject completeLevelUi;
    public void completeLevel()
    {
        completeLevelUi.SetActive(true);
    }
    public void endGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("restart", 1f);
        }
    }

    private void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
