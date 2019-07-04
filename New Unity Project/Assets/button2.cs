using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour
{
    private AudioSource audioSource;//オーディオの宣言
    public Reelcontroller reelcontroller;

    // Start is called before the first frame update
    void Start()
    {
        reelcontroller = GameObject.Find("ReelController").GetComponent<Reelcontroller>();
    }
    public void OnClick()
    {
        reelcontroller.stopReel2();
        audioSource = gameObject.GetComponent<AudioSource>();//オーディオの取得
        audioSource.Play();//ぴこっというオーディオの取得
    }
    // Update is called once per frame
    void Update()
    {

    }
}
