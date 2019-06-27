using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    public Reelcontroller reelcontroller;

    // Start is called before the first frame update
    void Start()
    {
        reelcontroller = GameObject.Find("ReelController").GetComponent<Reelcontroller>();
    }
    public void OnClick()
    {
        reelcontroller.stopReel();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
