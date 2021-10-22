using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadManager : MonoBehaviour
{
    public GameObject[] gamePrefabs;
    private OctopusMatch octopusMatchScript;
    private int tracker = 0;
    public GameObject gameOverScreen;
    private bool gameOver = false;
    private GameObject game1, game2, game3, game4, game5;

    // Starts up the first minigame, called upon the first frame.
    void Start()
    {
        gameOverScreen.SetActive(false);
        Instantiate(gamePrefabs[0], new Vector3((float)20.9, (float)0.7, (float)16.05), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadMinigame()
    {

    }

    public void Game1Win()
    {
        game1 = GameObject.Find("ColorMatch(Clone)");
        Destroy(game1);
        StartGame2();
    }

    public void Game2Win()
    {
        game2 = GameObject.Find("Instructions(Clone)");
        Destroy(game2);
        StartGame3();
    }
    
    public void StartGame2()
    {
        Instantiate(gamePrefabs[1], new Vector3((float)524.5164, (float)295.9212, (float)-3.378296), Quaternion.identity);
    }

    public void StartGame3()
    {
        Instantiate(gamePrefabs[2], new Vector3((float)80.1, (float)21.1, 0), Quaternion.identity);
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverScreen.SetActive(true);
    }
}