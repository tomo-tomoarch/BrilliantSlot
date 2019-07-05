using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour
{
    private AudioSource audioSource;//オーディオの宣言
    public Reelcontroller reelcontroller;
    
    public GameObject centerTopGetter;//centerMiddleGetterの宣言
    public GameObject centerMiddleGetter;//centerMiddleGetterの宣言
    public GameObject centerBottomGetter;//centerMiddleGetterの宣言

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

        Instantiate(centerTopGetter, new Vector3(5.98f, 2.57f, 0.0f), Quaternion.identity);//中リール上段にインスタンス化
        Instantiate(centerMiddleGetter, new Vector3(5.98f, 1.06f, 0.0f), Quaternion.identity);//中リール中段にインスタンス化
        Instantiate(centerBottomGetter, new Vector3(5.98f, -0.49f, 0.0f), Quaternion.identity);//中リール上段にインスタンス化
    }
 
}
