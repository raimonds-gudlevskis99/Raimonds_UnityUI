using UnityEngine;
using TMPro;

public class CharacterDescriptionController : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public TMP_Text descriptionText;

    [TextArea]
    public string[] descriptions;

    public void UpdateDescription()
    {
        descriptionText.text = descriptions[dropdown.value];
    }

    private void Start()
    {
        UpdateDescription();
    }
}