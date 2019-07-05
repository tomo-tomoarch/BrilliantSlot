﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    AudioSource[] sounds;//オーディオの宣言

    LeftTopGetter leftTopGetter;
    LeftMiddleGetter leftMiddleGetter;
    LeftBottomGetter leftBottomGetter;
    CenterTopGetter centerTopGetter;
    CenterMiddleGetter centerMiddleGetter;
    CenterBottomGetter centerBottomGetter;
    RightTopGetter rightTopGetter;
    RightMiddleGetter rightMiddleGetter;
    RightBottomGetter rightBottomGetter;


    
    public double coin;
    int koyaku;

    public GameObject score_object; // Textオブジェクト
    public GameObject win_object; // Textオブジェクト

    private void Awake()
    {
        sounds = gameObject.GetComponents<AudioSource>();//オーディオの取得

    }

    // Update is called once per frame
    void Update()
    {
        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "$"+ coin.ToString("F2");
    }
    // Start is called before the first frame update
    public void CheckMiddle()
    {
        Debug.Log("yobaretayo");

        leftTopGetter = GameObject.Find("LeftTopGetter(Clone)").GetComponent<LeftTopGetter>();//LeftTopGetterの取得
        leftMiddleGetter = GameObject.Find("LeftMiddleGetter(Clone)").GetComponent<LeftMiddleGetter>();//LeftMiddleGetterの取得
        leftBottomGetter = GameObject.Find("LeftBottomGetter(Clone)").GetComponent<LeftBottomGetter>();//LeftBottomGetterの取得

        centerTopGetter = GameObject.Find("CenterTopGetter(Clone)").GetComponent<CenterTopGetter>();//CenterTopGetterの取得
        centerMiddleGetter = GameObject.Find("CenterMiddleGetter(Clone)").GetComponent<CenterMiddleGetter>();//CenterMiddleGetterの取得
        centerBottomGetter = GameObject.Find("CenterBottomGetter(Clone)").GetComponent<CenterBottomGetter>();//CenterBottomGetterの取得

        rightTopGetter = GameObject.Find("RightTopGetter(Clone)").GetComponent<RightTopGetter>();//RightTopGetterの取得
        rightMiddleGetter = GameObject.Find("RightMiddleGetter(Clone)").GetComponent<RightMiddleGetter>();//RightMiddleGetterの取得
        rightBottomGetter = GameObject.Find("RightBottomGetter(Clone)").GetComponent<RightBottomGetter>();//RightBottomGetterの取得

        if (leftTopGetter.leftTopSymbol == centerTopGetter.centerTopSymbol && centerTopGetter.centerTopSymbol == rightTopGetter.rightTopSymbol)//上段の場合
        {
            koyaku = leftTopGetter.leftTopSymbol;

            if (koyaku == 0)
            {
                sounds[0].Play();
                StartCoroutine(Sound7Coroutine());

                WinR7();
            }
            else if (koyaku == 1)
            {
                sounds[1].Play();
                StartCoroutine(Sound7Coroutine());
                Win7();


            }
            else if (koyaku == 2)
            {
                sounds[2].Play();
                WinBrilliant();

            }
            else if (koyaku == 3)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinBell();



            }
            else if (koyaku == 4)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinCherry();



            }
            else if (koyaku == 5)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinWatermelon();


            }
            else
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinReplay();


            }
        }

        if (leftMiddleGetter.leftMiddleSymbol == centerMiddleGetter.centerMiddleSymbol && centerMiddleGetter.centerMiddleSymbol == rightMiddleGetter.rightMiddleSymbol)//中段の場合
        {
            koyaku = leftMiddleGetter.leftMiddleSymbol;

            if (koyaku == 0)
            {
                sounds[0].Play();
                StartCoroutine(Sound7Coroutine());
                WinR7();
            }
            else if (koyaku == 1)
            {
                sounds[1].Play();
                StartCoroutine(Sound7Coroutine());
                Win7();
            }
            else if (koyaku == 2)
            {
                sounds[2].Play();
                WinBrilliant();
            }
            else if (koyaku == 3)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinBell();
            }
            else if (koyaku == 4)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinCherry();
            }
            else if (koyaku == 5)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinWatermelon();
            }
            else
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinReplay();
            }
        }

        if (leftBottomGetter.leftBottomSymbol == centerBottomGetter.centerBottomSymbol && centerBottomGetter.centerBottomSymbol == rightBottomGetter.rightBottomSymbol)//下段の場合
        {
            koyaku = leftBottomGetter.leftBottomSymbol;

            if (koyaku == 0)
            {
                sounds[0].Play();
                StartCoroutine(Sound7Coroutine());
                WinR7();
            }
            else if (koyaku == 1)
            {
                sounds[1].Play();
                StartCoroutine(Sound7Coroutine());
                Win7();
            }
            else if (koyaku == 2)
            {
                sounds[2].Play();
                WinBrilliant();
            }
            else if (koyaku == 3)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinBell();
            }
            else if (koyaku == 4)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinCherry();
            }
            else if (koyaku == 5)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinWatermelon();
            }
            else
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinReplay();
            }
        }

        if (leftTopGetter.leftTopSymbol == centerMiddleGetter.centerMiddleSymbol && centerMiddleGetter.centerMiddleSymbol == rightBottomGetter.rightBottomSymbol)//斜め右下の場合
        {
            koyaku = leftTopGetter.leftTopSymbol;

            if (koyaku == 0)
            {
                sounds[0].Play();
                StartCoroutine(Sound7Coroutine());
                WinR7();
            }
            else if (koyaku == 1)
            {
                sounds[1].Play();
                StartCoroutine(Sound7Coroutine());
                Win7();
            }
            else if (koyaku == 2)
            {
                sounds[2].Play();
                WinBrilliant();
            }
            else if (koyaku == 3)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinBell();
            }
            else if (koyaku == 4)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinCherry();
            }

            else if (koyaku == 5)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinWatermelon();
            }
            else
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinReplay();
            }
        }

        if (leftBottomGetter.leftBottomSymbol == centerMiddleGetter.centerMiddleSymbol && centerMiddleGetter.centerMiddleSymbol == rightTopGetter.rightTopSymbol)//斜め右上の場合
        {
            koyaku = leftBottomGetter.leftBottomSymbol;

            if (koyaku == 0)
            {
                sounds[0].Play();
                StartCoroutine(Sound7Coroutine());
                WinR7();
            }
            else if (koyaku == 1)
            {
                sounds[1].Play();
                StartCoroutine(Sound7Coroutine());
                Win7();
            }
            else if (koyaku == 2)
            {
                sounds[2].Play();
                WinBrilliant();
            }
            else if (koyaku == 3)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinBell();
            }
            else if (koyaku == 4)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinCherry();
            }
            else if (koyaku == 5)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinWatermelon();
            }
            else
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
                WinReplay();
            }
        }

        IEnumerator SoundCoroutine()//コルーチン本体
        {
            yield return new WaitForSeconds(1.5f);

            sounds[4].Play();
        }
        IEnumerator Sound7Coroutine()//コルーチン本体
        {
            yield return new WaitForSeconds(5f);

            sounds[5].Play();
        }
    }

    void WinR7()
    {
        coin += 150;

        double win0 = 150.00f;

        Text win_text = win_object.GetComponent<Text>();
        win_text.text = "$" + win0.ToString("F2") + "WIN!!";
    }

    void Win7()
    {
        coin += 100;

        double win1 = 100.00f;

        Text win_text = win_object.GetComponent<Text>();
        win_text.text = "$" + win1.ToString("F2") + "WIN!!";
    }

    void WinBrilliant()
    {

    }

    void WinBell()
    {
        coin += 10;

        double win3 = 10.00f;

        Text win_text = win_object.GetComponent<Text>();
        win_text.text = "$" + win3.ToString("F2") + "WIN!!";
    }

    void WinCherry()
    {
        coin += 2.50f;

        double win4 = 2.50f;

        Text win_text = win_object.GetComponent<Text>();
        win_text.text = "$" + win4.ToString("F2") + "WIN!!";
    }

    void WinWatermelon()
    {
        coin += 5;

        double win5 = 5.00f;

        Text win_text = win_object.GetComponent<Text>();
        win_text.text = "$" + win5.ToString("F2") + "WIN!!";
    }

   
    void WinReplay()
    {
        coin += 1.50f;

        double win6 = 1.50f;

        Text win_text = win_object.GetComponent<Text>();
        win_text.text = "$" + win6.ToString("F2") + "WIN!!";
    }
}
