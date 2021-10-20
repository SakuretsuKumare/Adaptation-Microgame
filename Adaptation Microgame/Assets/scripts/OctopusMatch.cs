using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OctopusMatch : MonoBehaviour
{
    public GameObject debugMenu, self;
    public Text instructions;
    public float speed;
    public Button b1, b2, b3, b4;
    public Image Player;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartingCountDown");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator StartingCountDown()
    {
        for (int i = 3; i >= 0; i--)
        {
            yield return new WaitForSeconds(speed);
            instructions.text = "Starting in " + i;
        }
        instructions.text = "Quick, blend in!";
        Player.GetComponent<Image>().color=new Color32(13,245,0,255);
    }
    public void win()
    {
        self.gameObject.SetActive(false);
        debugMenu.gameObject.SetActive(true);
    }
    public void lose()
    {
        self.gameObject.SetActive(false);
        debugMenu.gameObject.SetActive(true);
    }

}
