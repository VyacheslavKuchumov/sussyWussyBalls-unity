using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    public int xLen = 10;
    public int yLen = 8;
    public GameObject[] balls;
    private GameObject ball_instance;

    // Start is called before the first frame update
    void Start()
    {
        float start_zPos = -4.8f;
        float start_yPos = 9f;
        float zPos = -4.8f;
        float yPos = 9f;
        
       
        for (int i = 0; i < xLen; i++) { 
            for (int j = 0; j < yLen; j++)
            {
                int randBallIndex = Random.Range(0, balls.Length);
                ball_instance = Instantiate(balls[randBallIndex], balls[randBallIndex].transform.position, Quaternion.identity) as GameObject;
                ball_instance.transform.position = new Vector3(0, yPos, zPos);
                zPos += 1;
            }
            zPos = start_zPos;
            yPos -= 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
