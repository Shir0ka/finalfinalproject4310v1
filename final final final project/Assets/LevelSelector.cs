using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{

    public int levle; 
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OpenScene()
    {
        SceneManager.LoadScene("GameplayDemo");
    }

    public void OpenScene2()
    {
        SceneManager.LoadScene("Level3");
    }

    public void OpenScene3()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Application.Quit();

    }

    public void OpenScene4()
    {
        SceneManager.LoadScene("MainMainMain");
    }
}
