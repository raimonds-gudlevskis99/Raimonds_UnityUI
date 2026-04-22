using UnityEngine;
using UnityEngine.UI;

public class ClothingResizeController : MonoBehaviour
{
    public Slider widthSlider;
    public Slider heightSlider;

    private RectTransform selectedClothing;
    private bool isUpdating = false;

    public void SetSelectedClothing(RectTransform clothing)
    {
        selectedClothing = clothing;

        if (selectedClothing != null)
        {
            isUpdating = true;
            widthSlider.value = selectedClothing.localScale.x;
            heightSlider.value = selectedClothing.localScale.y;
            isUpdating = false;
        }
    }

    public void ChangeSize()
    {
        if (selectedClothing == null || isUpdating) return;

        Vector3 scale = selectedClothing.localScale;
        scale.x = widthSlider.value;
        scale.y = heightSlider.value;
        selectedClothing.localScale = scale;
    }
}