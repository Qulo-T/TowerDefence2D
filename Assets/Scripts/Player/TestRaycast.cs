using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRaycast : MonoBehaviour
{
    public float radius;
    int layerMask = 2;

    private void Start()
    {
        layerMask = 1 << layerMask;
        layerMask = ~layerMask;
    }
    void Update()
    {
        Debug.DrawRay(transform.position, transform.up * radius, Color.green,1,false);
    }
    private void RayTest()
    {
        
        RaycastHit2D[] hit = Physics2D.CircleCastAll(transform.position, radius, Vector2.zero, radius, layerMask); 

        foreach (RaycastHit2D cast in hit)
        {
            if (cast.collider != null)
            {
               Debug.Log( cast.collider.gameObject.name);
            }
        }
    }
    private void OnMouseDown()
    {
        RayTest();
    }
}
