using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SneakyBoi : MonoBehaviour
{
    public GameObject debugMenu, self;
    private GameObject loadManager;
    public Image octopus, shark;
    public Sprite sharkLooking, sharkNotLooking;
    public float speed;
    private bool safe = false, won = false, lost = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("OctopusRotation");
        loadManager = GameObject.Find("Load Manager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (safe)
            {
                won = true;
            }
            else
            {
                lost = true;
            }
        }
        if (won)//win method
        {
            loadManager.GetComponent<LoadManager>().Game5Win();
        }
        if (lost)//lose function
        {
            loadManager.GetComponent<LoadManager>().GameOver();
        }
    }

    IEnumerator OctopusRotation()
    {
        while (true)
        {
            yield return new WaitForSeconds(speed);
            shark.sprite = sharkNotLooking;
            safe = true;
            yield return new WaitForSeconds(speed);
            shark.sprite = sharkLooking;
            safe = false;
        }
    }
}