using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WardrobeSelector : MonoBehaviour
{
    public TMP_Dropdown hatsDropdown;
    public TMP_Dropdown shirtsDropdown;
    public TMP_Dropdown pantsDropdown;
    public TMP_Dropdown shoesDropdown;

    public Sprite[] hatSprites;
    public Sprite[] shirtSprites;
    public Sprite[] pantsSprites;
    public Sprite[] shoesSprites;

    public Image selectedItemDisplay;

    [HideInInspector] public Sprite currentSelectedSprite;
    [HideInInspector] public string currentCategory;

    private void Start()
    {
        if (hatsDropdown != null)
            hatsDropdown.onValueChanged.AddListener(SelectHat);

        if (shirtsDropdown != null)
            shirtsDropdown.onValueChanged.AddListener(SelectShirt);

        if (pantsDropdown != null)
            pantsDropdown.onValueChanged.AddListener(SelectPants);

        if (shoesDropdown != null)
            shoesDropdown.onValueChanged.AddListener(SelectShoes);
    }

    public void SelectHat(int index)
    {
        Debug.Log("Selected hat index: " + index);

        if (index < 0 || index >= hatSprites.Length) return;

        currentSelectedSprite = hatSprites[index];
        currentCategory = "Hat";

        selectedItemDisplay.sprite = currentSelectedSprite;
        selectedItemDisplay.enabled = true;
        selectedItemDisplay.preserveAspect = true;
    }

    public void SelectShirt(int index)
    {
        Debug.Log("Selected shirt index: " + index);

        if (index < 0 || index >= shirtSprites.Length) return;

        currentSelectedSprite = shirtSprites[index];
        currentCategory = "Shirt";

        selectedItemDisplay.sprite = currentSelectedSprite;
        selectedItemDisplay.enabled = true;
        selectedItemDisplay.preserveAspect = true;
    }

    public void SelectPants(int index)
    {
        Debug.Log("Selected pants index: " + index);

        if (index < 0 || index >= pantsSprites.Length) return;

        currentSelectedSprite = pantsSprites[index];
        currentCategory = "Pants";

        selectedItemDisplay.sprite = currentSelectedSprite;
        selectedItemDisplay.enabled = true;
        selectedItemDisplay.preserveAspect = true;
    }

    public void SelectShoes(int index)
    {
        Debug.Log("Selected shoes index: " + index);

        if (index < 0 || index >= shoesSprites.Length) return;

        currentSelectedSprite = shoesSprites[index];
        currentCategory = "Shoes";

        selectedItemDisplay.sprite = currentSelectedSprite;
        selectedItemDisplay.enabled = true;
        selectedItemDisplay.preserveAspect = true;
    }
}