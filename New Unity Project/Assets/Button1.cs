using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    private AudioSource audioSource;//オーディオの宣言

    public GameObject leftMiddleGetter;

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

        Instantiate(leftMiddleGetter, new Vector3(2.97f, 1.06f, 0.0f), Quaternion.identity);
    }
}
