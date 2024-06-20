using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;

    bool gameStarted = false;

    public GameObject startScreen;
    public TextMeshProUGUI scoreText;

    int score = 0;
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            startScreen.SetActive(false);
            StartSpawning();
        }
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnObstacle", 0.5f, spawnRate);
    }
    void SpawnObstacle()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-maxX, maxX);
        Instantiate(obstacle, spawnPos, Quaternion.identity);

        score++;
        scoreText.text = "Score : " + score;
    }
}
