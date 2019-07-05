using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button3 : MonoBehaviour
{
    private AudioSource audioSource;//オーディオの宣言
    public Reelcontroller reelcontroller;

    public GameObject rightTopGetter;
    public GameObject rightMiddleGetter;
    public GameObject rightBottomGetter;
  

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

        Instantiate(rightTopGetter, new Vector3(8.94f, 2.57f, 0.0f), Quaternion.identity);
        Instantiate(rightMiddleGetter, new Vector3(8.94f, 1.06f, 0.0f), Quaternion.identity);
        Instantiate(rightBottomGetter, new Vector3(8.94f, -0.49f, 0.0f), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
