﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterTopGetter : MonoBehaviour
{
    public int centerTopSymbol;

    Reelcontroller reelcontroller;//Reelcontrollerの宣言

    private void Awake()
    {
        reelcontroller = GameObject.Find("ReelController").GetComponent<Reelcontroller>();//Reelcontrollerの取得

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("reel"))//reelタグが付いたオブジェクトにぶつかったら
        {
            ReelSymbol reelSymbol = other.GetComponent<ReelSymbol>(); //ぶつかった相手のReelSymbolにアクセス
            centerTopSymbol = reelSymbol.symbolNum;  //symbolNumをcenterMiddleSymbolに代入する

            Debug.Log("centerTop" + centerTopSymbol);
        }
    }
}
