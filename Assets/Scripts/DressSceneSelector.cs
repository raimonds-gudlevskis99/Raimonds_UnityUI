using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DressSceneSelector : MonoBehaviour
{
    
    public void OpenSelectedScene()
    {

        SceneManager.LoadScene("DressUpScene");
    }

    public void ExitProject()
    {
        Application.Quit();
        Debug.Log("Application closed");
    }
}