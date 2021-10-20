using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OctopusMatch1 : MonoBehaviour
{
    public GameObject debugMenu, self;
    public float speed;
    public Button b1, b2, b3, b4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
