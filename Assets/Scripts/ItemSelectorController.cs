using UnityEngine;
using UnityEngine.UI;

public class ItemSelectorController : MonoBehaviour
{
    public GameObject[] hats;
    public GameObject[] shirts;
    public GameObject[] pants;
    public GameObject[] shoes;

    public Image displayImage;

    private GameObject currentSelected;

    public void SelectHat(int index)
    {
        SelectItem(hats[index]);
    }

    public void SelectShirt(int index)
    {
        SelectItem(shirts[index]);
    }

    public void SelectPants(int index)
    {
        SelectItem(pants[index]);
    }

    public void SelectShoes(int index)
    {
        SelectItem(shoes[index]);
    }

    void SelectItem(GameObject item)
    {
        currentSelected = item;

        Image itemImage = item.GetComponent<Image>();
        displayImage.sprite = itemImage.sprite;

        displayImage.SetNativeSize();
    }

    public GameObject GetSelectedItem()
    {
        return currentSelected;
    }
}