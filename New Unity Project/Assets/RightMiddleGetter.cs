using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMiddleGetter : MonoBehaviour
{
    public int rightMiddleSymbol;

    Reelcontroller reelcontroller;

    private void Awake()
    {
        reelcontroller = GameObject.Find("ReelController").GetComponent<Reelcontroller>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("reel"))
        {
            //other.gameObject.SetActive(false); //ぶつかった相手をディアクティベート（消える
            //other.isTrigger = false;

            ReelSymbol reelSymbol = other.GetComponent<ReelSymbol>(); //ぶつかった相手のCardModel.csにアクセス
            //cardModel.ToggleFace(false);
            rightMiddleSymbol = reelSymbol.symbolNum;  //ぶつかった相手のカードインデックスをmiddleRankに代入する

            Debug.Log("rightMiddle" + rightMiddleSymbol);
        }
    }
}
