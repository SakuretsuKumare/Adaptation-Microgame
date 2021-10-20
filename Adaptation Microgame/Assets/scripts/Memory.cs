using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Memory : MonoBehaviour
{
    public GameObject memoryCube1, memoryCube2, memoryCube3, memoryCube4, debugMenu;
    public Text instructions;
    public Transform pos1, pos2, pos3, pos4;
    private int numberSpawned = 0, order=0;
    public bool won = false, lost = false;
    private bool readyToSpawn = true, readyToPlay=false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()//spawns the memnory items in given order
    {
        if (readyToSpawn && numberSpawned < 4)
        {
            readyToSpawn = false;
            switch (numberSpawned)//for some reason the  numbers are getting switched around, this is the only way I could make this function properly.
            {
                case 0:
                    Instantiate(memoryCube1, pos2);
                    memoryCube1.GetComponent<MemoryItem>().SetOrderNum(2);
                    break;
                case 1:
                    Instantiate(memoryCube2, pos4);
                    memoryCube2.GetComponent<MemoryItem>().SetOrderNum(3);
                    break;
                case 2:
                    Instantiate(memoryCube3, pos3);
                    memoryCube3.GetComponent<MemoryItem>().SetOrderNum(4);
                    break;
                case 3:
                    Instantiate(memoryCube4, pos1);
                    memoryCube4.GetComponent<MemoryItem>().SetOrderNum(1);
                    instructions.text = "Click the blocks in the order they apeared";
                    break;
            }
            StartCoroutine("OneSec");


        }
        if (won)
        {
            debugMenu.gameObject.SetActive(true);
            GameObject.Find("Memory").gameObject.SetActive(false);
            won = false;
            numberSpawned = 0;
            order = 0;
        }
        if (lost)
        {
            debugMenu.gameObject.SetActive(true);
            GameObject.Find("Memory").gameObject.SetActive(false);
            lost = false;
            numberSpawned = 0;
            order = 0;
        }
    }
    IEnumerator OneSec()
    {
        yield return new WaitForSeconds(.5f);
        readyToSpawn = true;
        numberSpawned++;

    }
    public int getOrder()
    {
        return order;
    }
    public int getNumberSpawned()
    {
        return numberSpawned;
    }
    public void OneDestroyed()
    {
        order++;
    }
    public bool getReadyToPlay()
    {
        return readyToPlay;
    }
}
