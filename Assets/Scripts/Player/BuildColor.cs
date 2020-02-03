using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildColor : MonoBehaviour
{
    [SerializeField] Color color1;
    [SerializeField] Color color2;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseEnter()
    {
        spriteRenderer.color = color2;
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = color1;
    }
}
