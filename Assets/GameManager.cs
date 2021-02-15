using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject playStateCanvas;
    
    private void Start()
    {

        gameOverCanvas.SetActive(false);
        playStateCanvas.SetActive(true);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        playStateCanvas.SetActive(false);
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        playStateCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        SceneManager.LoadScene(0);
        
    }

}
