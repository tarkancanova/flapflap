using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{

    [SerializeField] GameObject obj;

    float zOffSet = 15f;

    Vector3 offsetVector = new Vector3();

    Vector3 objPos;

    // Start is called before the first frame update
    void Start()
    {
        offsetVector = new Vector3 (0f, 0f, zOffSet);
    }

    // Update is called once per frame
    void Update()
    {
        objPos.x = obj.transform.position.x;
        transform.position = objPos - offsetVector;
    }
}
