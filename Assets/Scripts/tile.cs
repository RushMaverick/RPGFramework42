using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer myRenderer;
    [SerializeField] private GameObject highlight;

    private void Start() {
        highlight  = gameObject.transform.GetChild(0).gameObject;
    }
    public void Init(bool isOffset)
    {
        myRenderer.color = isOffset ? baseColor : offsetColor;
    }

    private void OnMouseOver() {
        highlight.SetActive(true);
    }

    private void OnMouseExit() {
        highlight.SetActive(false);
    }
}
