using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public ItemSelectorController selector;

    private GameObject draggingObject;
    private Canvas canvas;

    private void Start()
    {
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        GameObject selected = selector.GetSelectedItem();

        if (selected == null) return;

        draggingObject = Instantiate(selected, canvas.transform);

        RectTransform rect = draggingObject.GetComponent<RectTransform>();
        rect.position = transform.position;

        CanvasGroup cg = draggingObject.AddComponent<CanvasGroup>();
        cg.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (draggingObject != null)
        {
            draggingObject.GetComponent<RectTransform>().position += (Vector3)eventData.delta;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (draggingObject != null)
        {
            Destroy(draggingObject);
        }
    }
}