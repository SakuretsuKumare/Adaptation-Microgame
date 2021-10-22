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

    // Starts up the first minigame, called upon the first frame.
    void Start()
    {
        gameOverScreen.SetActive(true);
        Instantiate(gamePrefabs[tracker], new Vector3((float)20.9, (float)0.7, (float)16.05), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadMinigame()
    {

    }

    void Game1Win()
    {
        Destroy(gamePrefabs[tracker]);

        StartCoroutine("NextGameAnimation");
    }
    
    void StartGame2()
    {
        Instantiate(gamePrefabs[tracker], new Vector3((float)524.5164, (float)295.9212, (float)-3.378296), Quaternion.identity);
    }

    IEnumerator NextGameAnimation()
    {
        tracker++;
        yield return new WaitForSeconds(1f);
        StartGame2();
    }

    void GameOver()
    {
        Destroy(gamePrefabs[tracker]);
        gameOver = true;
        gameOverScreen.SetActive(true);
    }
}