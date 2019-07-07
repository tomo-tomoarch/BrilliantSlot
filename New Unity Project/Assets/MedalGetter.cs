using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalGetter : MonoBehaviour
{
    GameController gameController;

    private void Awake()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();//Reelcontrollerの取得
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("medal"))
        {
            Destroy(other.gameObject); //ぶつかった相手をディアクティベート（消える
            gameController.coin += 0.5f;
        }
    }
}
