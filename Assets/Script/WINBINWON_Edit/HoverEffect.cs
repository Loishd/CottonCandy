using UnityEngine;
using UnityEngine.EventSystems;

public class HoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 originalPosition;
    private Vector3 hoverPosition;
    private RectTransform rectTransform;

    public float floatAmount = 10f;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPosition = rectTransform.anchoredPosition;
        hoverPosition = originalPosition + new Vector3(0, floatAmount, 0);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        rectTransform.anchoredPosition = hoverPosition;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rectTransform.anchoredPosition = originalPosition;
    }
}