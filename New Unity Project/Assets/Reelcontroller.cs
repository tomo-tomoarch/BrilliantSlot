using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reelcontroller : MonoBehaviour
{
    public GameObject Reel; //リールを取得
    public GameObject Reel2;
    public GameObject Reel3;

    Vector3 initialpos; //初期位置
    Vector3 initialpos2;
    Vector3 initialpos3;

    float speed1; //リールの回転速度
    float speed2;
    float speed3;

    bool stopflag1 = false;
    bool stopflag2 = false;
    bool stopflag3 = false;

    ReelGenerator1 reelGenerator1;
    ReelGenerator1 reelGenerator2;
    ReelGenerator1 reelGenerator3;

    private void Awake()　//ゲーム開始時に
    {
        
        initialpos = this.Reel.transform.position;　//初期位置を取得しておく
        initialpos2 = this.Reel2.transform.position;
        initialpos3 = this.Reel3.transform.position;

        reelGenerator1 = GameObject.Find("ReelGenerator").GetComponent<ReelGenerator1>();
        reelGenerator2 = GameObject.Find("ReelGenerator (1)").GetComponent<ReelGenerator1>();
        reelGenerator3 = GameObject.Find("ReelGenerator (2)").GetComponent<ReelGenerator1>();
    }
    public void StartReel()
    {
        reelGenerator1.GenerateReel();
        reelGenerator2.GenerateReel();
        reelGenerator3.GenerateReel();

        speed1 = -0.35f;　//リールの回転スピードの代入
        speed2 = -0.35f;
        speed3 = -0.35f;

        stopflag1 = false;
        stopflag2 = false;
        stopflag3 = false;

    }   

    private void Update()　//ゲームが始まったら
    {
        this.Reel.transform.Translate(0, speed1, 0);　//リールをｙ方向（下）に動かす
        this.Reel2.transform.Translate(0, speed2, 0);
        this.Reel3.transform.Translate(0, speed3, 0);

        if (Reel.transform.position.y < -130)　//リールが一番下に来たら
        {
            this.Reel.transform.position = initialpos;　//初期位置に戻す
        }

        if (Reel2.transform.position.y < -130f)
        {
            this.Reel2.transform.position = initialpos2;
        }

        if (Reel3.transform.position.y < -130f)
        {
            this.Reel3.transform.position = initialpos3;
        }

        if (stopflag1 && 0.85 <= Mathf.Abs(Reel.transform.position.y % 1.5f) && Mathf.Abs(Reel.transform.position.y % 1.5f) < 0.88)
        {
            speed1 = 0;//リールの回転スピードを０にする

        }

        if (stopflag2 && 0.85 <= Mathf.Abs(Reel2.transform.position.y % 1.5f) && Mathf.Abs(Reel2.transform.position.y % 1.5f) < 0.88)
        {
            speed2 = 0;//リールの回転スピードを０にする

        }

        if (stopflag3 && 0.85 <= Mathf.Abs(Reel3.transform.position.y % 1.5f) && Mathf.Abs(Reel3.transform.position.y % 1.5f) < 0.88)
        {
            speed3 = 0;//リールの回転スピードを０にする

        }
    }

    public void stopReel() //この関数がボタン1を押すと呼ばれる
    {
        stopflag1 = true;
        speed1 = -0.03f;
    }

    public void stopReel2()
    {
        stopflag2 = true;
        speed2 = -0.03f;
    }

    public void stopReel3()
    {
        stopflag3 = true;
        speed3 = -0.03f;
    }
}

