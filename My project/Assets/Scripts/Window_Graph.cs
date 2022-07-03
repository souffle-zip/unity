using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//for Image

public class Window_Graph : MonoBehaviour
{
    private RectTransform graphContainer;
    [SerializeField] private Sprite circleSprite;
    private void Awake() {
        graphContainer = transform.Find("graphContainer").GetComponent<RectTransform>();
        CreateCircle(new Vector2(100,100));
    }

    private void CreateCircle(Vector2 anchoredPosition){
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);//false for change position with parent
        gameObject.GetComponent<Image>().sprite = circleSprite;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11, 11);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
    }
}
