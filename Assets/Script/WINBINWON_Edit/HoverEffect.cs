using UnityEngine;
using UnityEngine.EventSystems;

public class HoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 originalPosition;
    private Vector3 hoverPosition;
    private RectTransform rectTransform;

    public float floatAmount1 = 10f;
    public float floatAmount2 = 10f;
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPosition = rectTransform.anchoredPosition;
        hoverPosition = originalPosition + new Vector3(0, floatAmount1, 0);
        hoverPosition = originalPosition + new Vector3(floatAmount2,0 , 0);
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