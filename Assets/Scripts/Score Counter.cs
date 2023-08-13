using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreCounter : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        IncreaseScoreForCounter();
        Debug.Log(GameManager.Instance.Score);
        
    }

    private void IncreaseScoreForCounter()
    {
        GameManager.Instance.Score += 0.5f;
    }

}
