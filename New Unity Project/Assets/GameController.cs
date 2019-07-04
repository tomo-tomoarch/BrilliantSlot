using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    AudioSource[] sounds;//オーディオの宣言

    LeftMiddleGetter leftMiddleGetter;
    CenterMiddleGetter centerMiddleGetter;
    RightMiddleGetter rightMiddleGetter;

    int koyaku;

    private void Awake()
    {
        sounds = gameObject.GetComponents<AudioSource>();//オーディオの取得
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Start is called before the first frame update
    public void CheckMiddle()
    {
        Debug.Log("yobaretayo");

        leftMiddleGetter = GameObject.Find("LeftMiddleGetter(Clone)").GetComponent<LeftMiddleGetter>();//LeftMiddleGetterの取得
        centerMiddleGetter = GameObject.Find("CenterMiddleGetter(Clone)").GetComponent<CenterMiddleGetter>();//CenterMiddleGetterの取得
        rightMiddleGetter = GameObject.Find("RightMiddleGetter(Clone)").GetComponent<RightMiddleGetter>();//RightMiddleGetterの取得

        if(leftMiddleGetter.leftMiddleSymbol == centerMiddleGetter.centerMiddleSymbol && centerMiddleGetter.centerMiddleSymbol == rightMiddleGetter.rightMiddleSymbol)
        {
            koyaku = leftMiddleGetter.leftMiddleSymbol;

            if(koyaku ==0)
            {
                sounds[0].Play();
                StartCoroutine(Sound7Coroutine());
            }
            else if(koyaku == 1)
            {
                sounds[1].Play();
                StartCoroutine(Sound7Coroutine());
            }
            else if (koyaku == 2)
            {
                sounds[2].Play();
            }
            else if (koyaku == 3)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
            }
            else if (koyaku == 4)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
            }
            else if (koyaku == 5)
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
            }
            else
            {
                sounds[3].Play();
                StartCoroutine(SoundCoroutine());
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

    
}
