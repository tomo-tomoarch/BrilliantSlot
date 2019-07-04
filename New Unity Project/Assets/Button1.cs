using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    private AudioSource audioSource;//オーディオの宣言

    public Reelcontroller reelcontroller;

    void Start()
    {
        reelcontroller = GameObject.Find("ReelController").GetComponent<Reelcontroller>();
    }
    public void OnClick()
    {
        reelcontroller.stopReel();

        audioSource = gameObject.GetComponent<AudioSource>();//オーディオの取得
        audioSource.Play();//ぴこっというオーディオの取得
    }
}
