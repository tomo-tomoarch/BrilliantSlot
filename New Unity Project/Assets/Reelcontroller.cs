using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reelcontroller : MonoBehaviour
{
    public GameObject Reel;
    public GameObject Reel2;
    public GameObject Reel3;

    Vector3 initialpos;
    Vector3 initialpos2;
    Vector3 initialpos3;

    float stoppos1;
    public string buttonTag1 = "button1";

    float speed;

    private void Awake()
    {
        
        initialpos = this.Reel.transform.position;
        initialpos2 = this.Reel2.transform.position;
        initialpos3 = this.Reel3.transform.position;

        speed = -0.35f;
    }
    private void Update()
    {
        this.Reel.transform.Translate(0, speed, 0);
        this.Reel2.transform.Translate(0, speed, 0);
        this.Reel3.transform.Translate(0, speed, 0);

        if (Reel.transform.position.y < -3.78f)
        {
            this.Reel.transform.position = initialpos;
        }

        if (Reel2.transform.position.y < -3.78f)
        {
            this.Reel2.transform.position = initialpos2;
        }

        if (Reel3.transform.position.y < -3.78f)
        {
            this.Reel3.transform.position = initialpos3;
        }
    }

    public void stopReel()
    {
        speed = 0;
       
    }
}

