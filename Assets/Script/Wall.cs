using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public void Dead()
    {
        Destroy(gameObject);
    }

    public AudioSource soundEffect;
    public AudioSource SoundCar;

    private void OnCollisionEnter2D(Collision2D collision) // 플레이어 벽 충돌 시 사망
    {
        if (collision.gameObject.CompareTag("Icon"))
        {
            Health.health -= 34f;
            soundEffect.Play();
            Debug.Log("멧돼지가 벽에 머리를 박아 소리를 지릅니다.");

            if (Health.health <= 0f)
            {
                Time.timeScale = 0f;
                Debug.Log("멧돼지가 사망했습니다..");
            }
        }
        else if (collision.gameObject.CompareTag("Car"))
        {
            SoundCar.Play();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
}
}
