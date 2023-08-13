using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class Obstaclegenerator : MonoBehaviour
{
    [SerializeField] private GameObject obs;
    private readonly float _lengthsOfObstacles = 15f;
    private readonly float _verticalSpaceBetweenObstacles = 2f;
    private readonly float _offSet = 0.5f;
    private float _xCoordinate = 0f;
    private Vector3 _upperVectorCoordinate;
    private Vector3 _lowerVectorCoordinate;
    private float upperObstacleY;
    private float lowerObstacleY;


    private void Start()
    {


        InvokeRepeating("GenerateObstacles", 0, 1f);

    }

    private void GenerateObstacles()
    {
        //Generating the upper obstacle
        upperObstacleY = Random.Range(6, 11);
        
        
        lowerObstacleY = upperObstacleY - _lengthsOfObstacles - _verticalSpaceBetweenObstacles - _offSet;
        
        _upperVectorCoordinate= new Vector3(_xCoordinate, upperObstacleY);
        _lowerVectorCoordinate = new Vector3(_xCoordinate, lowerObstacleY);
        



        GameObject createdUpperObstacle = Instantiate(obs, _upperVectorCoordinate, Quaternion.identity);
        GameObject createdLowerObstacle = Instantiate(obs, _lowerVectorCoordinate, Quaternion.identity);

        _xCoordinate += 6;


    }


}
