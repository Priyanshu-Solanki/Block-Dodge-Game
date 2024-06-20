using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float obstacleSpeed;
    void Update()
    {
        transform.position += new Vector3(0, -(obstacleSpeed*Time.deltaTime),0);
        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
