using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    public TextMeshProUGUI MyScoreText;
    private int ScoreNum;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("Coin"))
        {
            ScoreNum += 1;
            Debug.Log("코인을 획득했다 난 부자다 야호 !");
            Destroy(gameObject);
            MyScoreText.text = "코인 : " + ScoreNum;
        }
    }
}


