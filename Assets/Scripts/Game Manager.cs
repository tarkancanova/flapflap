using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance { get; private set; }
    public bool isGameStarted;
    [SerializeField] private GameObject mainScreen;
    [SerializeField] private GameObject gameScreen;
    List<float> scores = new List<float>();

    public bool isDead;

    public static GameManager Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType<GameManager>();
            }

            return _instance;

        }
    }

    private void Awake()
    {

        
        //if (_instance && _instance != this)
        //{
        //    Destroy(gameObject);
        //}
        //else
        //{
        //    _instance = this;
        //    DontDestroyOnLoad(gameObject);
        //}
    }//Singleton



    private float _score = 0;

    private float _highScore = 0;

    public float HighScore
    {
        get => _highScore;
        set => _highScore = value;
    }


    public float Score
    {
        get => _score;
        set
        {
            _score = value;
        }
    } //Score



    public void StartGame()
    {
        isGameStarted = true;

        

        if (!isDead)
        {
            mainScreen.SetActive(false);
            gameScreen.SetActive(true);
        }
        Time.timeScale = 1.0f;
    }

    public void EndGame()
    {
        isGameStarted = false;
        Time.timeScale = 0;
        
        
        


        if (isDead)
        {
           mainScreen.SetActive(true);
           gameScreen.SetActive(false);

        }

    }

    public void Lose()
    {

        SceneManager.LoadScene(0);
        
        scores.Add(GameManager.Instance.Score);
        GameManager.Instance.HighScore = scores.Max();
        EndGame();

    } //Start Game, End Game and Win/Lose

}
