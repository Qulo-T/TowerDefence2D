using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyCell : MonoBehaviour
{
    private bool isEmpty = true;

    private void OnMouseDown()
    {
        if (isEmpty)
        {
            glObjects.shopGL.SetEmptyCell(gameObject);
            glObjects.shopGL.gameObject.SetActive(true);
        }
    }

    public void SetStatus(bool isempty)
    {
        isEmpty = isempty;
    }

}
