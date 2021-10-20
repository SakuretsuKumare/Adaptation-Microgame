using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SneakyBoi : MonoBehaviour
{
    public GameObject debugMenu, self;
    public Text PC, NPC;
    public float speed;
    private bool safe = false, won = false, lost=false;    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("OctopusRotation");
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
        if (won)
        {
            won = false;
            StopCoroutine("OctopusRotation");
            self.gameObject.SetActive(false);
            debugMenu.gameObject.SetActive(true);

        }
        if (lost)
        {
            lost = false;
            StopCoroutine("OctopusRotation");
            self.gameObject.SetActive(false);
            debugMenu.gameObject.SetActive(true);
        }
    }

    IEnumerator OctopusRotation()
    {
        while (true)
        {
            yield return new WaitForSeconds(speed);
            NPC.text = "Not watching";
            safe = true;
            yield return new WaitForSeconds(speed);
            NPC.text = "Watching";
            safe = false;
        }
    }
}
