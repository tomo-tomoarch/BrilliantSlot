using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private AudioSource audioSource;//オーディオの宣言

    public Reelcontroller reelcontroller;//ReelControllerの宣言
    public ReelGenerator1 reelgenerator; //ReelGenerator1の宣言

    void Start()
    {
        reelcontroller = GameObject.Find("ReelController").GetComponent<Reelcontroller>();//ReelControllerの取得
        reelgenerator = GameObject.Find("ReelGenerator").GetComponent<ReelGenerator1>();//ReelGenerator1の取得
    }
    public void OnClick()
    {
        audioSource = gameObject.GetComponent<AudioSource>();//オーディオの取得
        audioSource.Play();//ガチャっというオーディオの取得

        this.transform.Translate(0, -4.33f, 0);//レバーを下に落とす

        StartCoroutine(LeverCoroutine());//コルーチンを始める（レバーを0，5秒後に戻すため）

        
        reelgenerator.DestroyReel();//リールを全消しする関数を呼ぶ
        reelcontroller.StartReel();//リールを再生成して回す関数を呼ぶ
    }

    IEnumerator LeverCoroutine()//コルーチン本体
    {
        yield return new WaitForSeconds(0.5f);//0.5秒待つ

        this.transform.Translate(0, 4.33f, 0);//レバーを元に戻す
    }
}
