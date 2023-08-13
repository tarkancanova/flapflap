using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text text;

    private void Awake()
    {
        // Check if GameManager.Instance is null
        if (GameManager.Instance == null)
        {
            Debug.LogError("GameManager instance is not set!");
            return;
        }
    }
    private void Update()
    {
         text.text = "Score: " + GameManager.Instance.Score.ToString();

    }
}
