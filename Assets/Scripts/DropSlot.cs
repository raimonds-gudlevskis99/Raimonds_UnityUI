using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public string acceptedCategory;
    public WardrobeSelector wardrobeSelector;
    public ClothingResizeController resizeManager;

    public void OnDrop(PointerEventData eventData)
    {
        if (wardrobeSelector.currentSelectedSprite == null) return;

        // Pārbauda, vai šis item der šai drop zonai
        if (wardrobeSelector.currentCategory != acceptedCategory) return;

        // Izdzēš veco item šajā drop zonā
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        // Izveido jaunu UI objektu
        GameObject newItem = new GameObject("Equipped_" + acceptedCategory);
        newItem.transform.SetParent(transform, false);

        Image itemImage = newItem.AddComponent<Image>();
        itemImage.sprite = wardrobeSelector.currentSelectedSprite;
        itemImage.preserveAspect = true;

        RectTransform rect = newItem.GetComponent<RectTransform>();
        rect.anchorMin = new Vector2(0.5f, 0.5f);
        rect.anchorMax = new Vector2(0.5f, 0.5f);
        rect.pivot = new Vector2(0.5f, 0.5f);
        rect.anchoredPosition = Vector2.zero;
        rect.localScale = Vector3.one;
        rect.sizeDelta = new Vector2(100, 100);

        if (resizeManager != null)
        {
            resizeManager.SetSelectedClothing(rect);
        }
    }
}