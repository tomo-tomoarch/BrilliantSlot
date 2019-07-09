using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMiddleGetter : MonoBehaviour
{
    public int leftMiddleSymbol;

    Reelcontroller reelcontroller;

    private void Awake()
    {
        reelcontroller = GameObject.Find("ReelController").GetComponent<Reelcontroller>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("reel"))
        {
           

            ReelSymbol reelSymbol = other.GetComponent<ReelSymbol>(); 
           
            leftMiddleSymbol = reelSymbol.symbolNum;

            Debug.Log("LeftMiddle" + leftMiddleSymbol);
        }
    }
}
