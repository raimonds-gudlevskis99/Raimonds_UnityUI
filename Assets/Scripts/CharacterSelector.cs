using UnityEngine;
using TMPro;

public class CharacterSelector : MonoBehaviour
{
    public TMP_Dropdown characterDropdown;
    public GameObject[] characters;

    public void ChangeCharacter()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetActive(i == characterDropdown.value);
        }
    }

    private void Start()
    {
        ChangeCharacter();
    }
}