using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public Reelcontroller reelcontroller;
    public ReelGenerator1 reelgenerator; 

    // Start is called before the first frame update
    void Start()
    {
        reelcontroller = GameObject.Find("ReelController").GetComponent<Reelcontroller>();
        reelgenerator = GameObject.Find("ReelGenerator").GetComponent<ReelGenerator1>();
    }
    public void OnClick()
    {
        reelgenerator.DestroyReel();
        reelcontroller.StartReel();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
