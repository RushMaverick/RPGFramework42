using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer myRenderer;

    public void Init(bool isOffset)
    {
        myRenderer.color = isOffset ? baseColor : offsetColor;
        Debug.Log(myRenderer.color);
    }
}
