using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadManager : MonoBehaviour
{
    public GameObject[] gamePrefabs;
    private OctopusMatch octopusMatchScript;
    public GameObject gameOverScreen, victoryScreen;
    private bool gameOver = false;
    private GameObject game1, game2, game3, game4, game5;

    // Starts up the first minigame, called upon the first frame.
    void Start()
    {
        gameOverScreen.SetActive(false);
        victoryScreen.SetActive(false);
        Instantiate(gamePrefabs[0], new Vector3((float)20.9, (float)0.7, (float)16.05), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    // Moves on to the game 2.
    public void Game1Win()
    {
        game1 = GameObject.Find("ColorMatch(Clone)");
        Destroy(game1);
        StartGame2();
    }

    // Moves on to game 3.
    public void Game2Win()
    {
        game2 = GameObject.Find("Instructions(Clone)");
        Destroy(game2);
        StartGame3();
    }

    // Moves on to game 4.
    public void Game3Win()
    {
        game3 = GameObject.Find("Memory(Clone)");
        Destroy(game3);
        StartGame4();
    }

    // Moves on to game 5.
    public void Game4Win()
    {
        game4 = GameObject.Find("RG(Clone)");
        Destroy(game4);
        StartGame5();
    }

    // No more minigames so you win!
    public void Game5Win()
    {
        victoryScreen.SetActive(true);
    }
    
    // Loads game 2.
    public void StartGame2()
    {
        Instantiate(gamePrefabs[1], new Vector3((float)524.5164, (float)295.9212, (float)-3.378296), Quaternion.identity);
    }

    // Loads game 3.
    public void StartGame3()
    {
        Instantiate(gamePrefabs[2], new Vector3((float)80.1, (float)21.1, 0), Quaternion.identity);
    }

    // Loads game 4.
    public void StartGame4()
    {
        Instantiate(gamePrefabs[3], new Vector3((float)18.355, (float)1.7705, (float)32.547), Quaternion.identity);
    }

    // Loads game 5.
    public void StartGame5()
    {
        Instantiate(gamePrefabs[4], new Vector3((float)536.5, (float)257.5, 0), Quaternion.identity);
    }

    // You lose, game over. Has option to restart from the beginning.
    public void GameOver()
    {
        gameOver = true;
        gameOverScreen.SetActive(true);
    }
}