using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToGame()
    {
       SceneManager.LoadScene("MainScene");
    }

    public void pauseGame()
    {
        Debug.Log("Game Paused");
    }
}
