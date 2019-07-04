using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button3 : MonoBehaviour
{
    private AudioSource audioSource;//オーディオの宣言
    public Reelcontroller reelcontroller;
    public GameObject rightMiddleGetter;

    // Start is called before the first frame update
    void Start()
    {
        reelcontroller = GameObject.Find("ReelController").GetComponent<Reelcontroller>();
    }
    public void OnClick()
    {
        reelcontroller.stopReel3();
        audioSource = gameObject.GetComponent<AudioSource>();//オーディオの取得
        audioSource.Play();//ぴこっというオーディオの取得

        Instantiate(rightMiddleGetter, new Vector3(8.94f, 1.06f, 0.0f), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
