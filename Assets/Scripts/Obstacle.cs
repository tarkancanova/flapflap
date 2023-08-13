using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Obstacle : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        GameManager.Instance.Lose();
        GameManager.Instance.isDead = true;



    }


}
