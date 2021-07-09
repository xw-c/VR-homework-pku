using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour {
    public void PlayGame()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Snake");
    }
    public void QuitGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("baijiang");
    } 
}
