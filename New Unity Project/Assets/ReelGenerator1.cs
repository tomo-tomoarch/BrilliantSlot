using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelGenerator1 : MonoBehaviour
{
    public int line_ID = 0; //リールのid
    public GameObject[] imgobj; //絵柄のプレハブを格納
  
    //int[] current = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, - 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }; //配列に全体の絵柄idを格納
    int[] current = new int[90];
    GameObject[] tmp_obj = new GameObject[90];
    Transform[] img_pos = new Transform[90];

    Transform pos;  //リールのTransform
    Vector3 initpos; //リールの初期位置

    int div0=5;
    int div1=10;
    int div2=15;
    int div3=25;
    int div4=40;
    int div5=60;
    int div6=80;

    void Awake()
    {
        GenerateReel();
    }

    public void GenerateReel()
    {
        Debug.Log("generateReel");

            pos = GetComponent<Transform>();
        initpos = pos.localPosition;
        for (int i = 0; i < 90; i++)
        {
            Vector3 pos = new Vector3(0.0f, -1.5f + (1.5f * i), 0.0f);
            int tmp;
            int rand = Random.Range(0, 91);//絵柄をランダムで生成
            if (0 < rand && rand < div0
                )
            {
                tmp = 0;
            }
            else if (div0 < rand && rand < div1
               )
            {
                tmp = 1;
            }
            else if (div1 < rand && rand < div2
               )
            {
                tmp = 2;
            }
            else if (div2 < rand && rand < div3
               )
            {
                tmp = 3;
            }
            else if (div4 < rand && rand < div5
               )
            {
                tmp = 4;
            }
            else if (div5 < rand && rand < div6
               )
            {
                tmp = 5;
            }
            else
            {
                tmp = 6;
            }

            current[i] = tmp;
            tmp_obj[i] = (GameObject)Instantiate(imgobj[tmp]); //プレハブからGameObjectを生成
            tmp_obj[i].transform.SetParent(transform, false); //リールのオブジェクトを親にする
            img_pos[i] = tmp_obj[i].GetComponent<Transform>();
            img_pos[i].localPosition = pos;
        }
    }

    public void DestroyReel() {

    GameObject[] reels = GameObject.FindGameObjectsWithTag("reel");

        foreach (GameObject i in reels)
        {
            Destroy(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
