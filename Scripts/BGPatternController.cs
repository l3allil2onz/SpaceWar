using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGPatternController : MonoBehaviour
{
    public List<GameObject> patterns = new List<GameObject>();
    List<RectTransform> patternRects = new List<RectTransform>();
    float offsetX;

    void Start()
    {
        for (int i = 0; i < patterns.Count; i++)
        {
            patternRects.Add(patterns[i].GetComponent<RectTransform>());
        }
        offsetX = transform.parent.GetComponent<RectTransform>().rect.width;
    }

    void Update()
    {
        GeneratePattern();
    }

    public void GeneratePattern()
    {
        float pat1PosX = patternRects[0].anchoredPosition.x;
        float pat2PosX = patternRects[1].anchoredPosition.x;

        if (pat1PosX <= -626)
        {
            patternRects[0].anchoredPosition = new Vector2(626, patternRects[0].anchoredPosition.y);
        }
        if(pat2PosX <= -626)
        {
            patternRects[1].anchoredPosition = new Vector2(626, patternRects[0].anchoredPosition.y);
        }
    }
}
