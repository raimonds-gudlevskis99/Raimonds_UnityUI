using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BackMenuController : MonoBehaviour
{
    
    public void OpenSelectedScene()
    {

        SceneManager.LoadScene("StartScene");
    }

    public void ExitProject()
    {
        Application.Quit();
        Debug.Log("Application closed");
    }
}