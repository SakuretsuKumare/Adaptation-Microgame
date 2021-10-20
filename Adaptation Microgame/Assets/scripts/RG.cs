﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RG : MonoBehaviour
{

    public GameObject inputDirection1, inputDirection2, inputDirection3, inputdirection4, debugMenu, RhythmUI;
    public int howManyDestroyed;
    public Transform sLR, sLU, sLL, sLD;
    public Collider inputWindow;
    public float speed;
    private int numberSpawned;
    public Text description;
    private float countDown=3;
    private bool timeToSpawn=true, timeToCount=true;
    public bool won=false,lost=false;
    // Start is called before the first frame update
    void Start()
    {
        howManyDestroyed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (countDown >= 0&&timeToCount)
        {
            timeToCount = false;
            description.text = "Press the button to the rhythm \n Starts in : " + countDown;
            StartCoroutine("OneSecondII");
            
        }
        else if(timeToSpawn&&countDown<=0)
        {
            description.text = "Press the button to the rhythm";
            timeToSpawn = false;
            switch (numberSpawned)
            {
                case 0:
                    Instantiate(inputDirection1, sLL);
                    break;
                case 1:
                    Instantiate(inputDirection2, sLR);
                    break;
                case 2:
                    Instantiate(inputDirection3, sLU);
                    break;
                case 3:
                    Instantiate(inputdirection4, sLD);
                    break;
                
            }
            numberSpawned++;
            StartCoroutine("OneSecond");
        }
        if (howManyDestroyed == 4)
        {
            won = true;
        }
        if (won)
        {
            debugMenu.gameObject.SetActive(true);
            RhythmUI.gameObject.SetActive(false);
            won = false;
            countDown = 3;
            howManyDestroyed = 0;
        }
        if (lost)
        {
            debugMenu.gameObject.SetActive(true);
            RhythmUI.gameObject.SetActive(false);
            lost = false;
            countDown = 3;
            howManyDestroyed = 0;
        }
    }
    IEnumerator OneSecond()
    {
        yield return new WaitForSeconds(1f);
        timeToSpawn = true;

    }
    IEnumerator OneSecondII()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("one second II triggered");
        countDown--;
        timeToCount = true;


    }
    
    }
