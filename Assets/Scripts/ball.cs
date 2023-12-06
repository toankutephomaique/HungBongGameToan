using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    GameController m_gc;

    private void Start()
    {
        m_gc = FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            m_gc.IncrementScore();
            Destroy(gameObject);

            Debug.Log("Qua bong da va cham voi gia do");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("DeathZone"))
        {
            m_gc.SetGameoverState(true);
            Destroy(gameObject);

            Debug.Log("Qua bong da va cham voi DeathZone, gameover");
        }
    }
}
