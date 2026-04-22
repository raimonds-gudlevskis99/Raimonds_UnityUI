using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenuController : MonoBehaviour
{
    public TMP_Dropdown sceneDropdown;

    public void OpenSelectedScene()
    {
        if (sceneDropdown.value == 0)
        {
            SceneManager.LoadScene("DressUpScene");
        }
        else if (sceneDropdown.value == 1)
        {
            SceneManager.LoadScene("StartScene");
        }
    }

    public void ExitProject()
    {
        Application.Quit();
        Debug.Log("Application closed");
    }
}