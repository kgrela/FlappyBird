using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject titleCanvas;

    public int mouse = 0;

    private void Start()
    {
        if(mouse == 0)
        {
            Time.timeScale = 0;
            titleCanvas.SetActive(true);
        }
        
    }


    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }


}
