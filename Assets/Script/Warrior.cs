using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Warrior : MonoBehaviour
{
    public Vector2 Player;
    public TextMeshProUGUI MyScoreText;
    private int ScoreNum;
    public AudioSource MyCoin;

    private void OnTriggerEnter2D(Collider2D other) // 코인 획득 스코어
    {
        if (other.gameObject.transform.CompareTag("Coin"))
        {
            ScoreNum += 1;
            Debug.Log("코인을 획득했다 난 부자다 야호 !");
            MyCoin.Play();
            Destroy(other.gameObject);
            MyScoreText.text = "코인 : " + ScoreNum;
        }
    }

    void Start()
    {
        transform.Translate(0f, 7f, 0f); // 멧돼지 게임시작 시 텔레포트
    }

    void Update() // 방향키 및 멧돼지 조종 시 색깔
    {
        Player = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.x += 0.05f;
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.x -= 0.05f;
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Player.y += 0.05f;
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.y -= 0.05f;
            GetComponent<SpriteRenderer>().color = Color.magenta;
        }

        transform.Translate(Player);

    }
}
