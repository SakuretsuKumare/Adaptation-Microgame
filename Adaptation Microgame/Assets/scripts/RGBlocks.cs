using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGBlocks : MonoBehaviour
{
    private GameObject scriptableObject;
    private RG mainScript;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        scriptableObject = GameObject.Find("ScriptObject");
        mainScript = scriptableObject.GetComponent<RG>();
    }

    // Update is called once per frame
    void Update()
    {   //programming the rhythm game controls
        transform.Translate(Vector3.down * Time.deltaTime * mainScript.speed);
        if (Input.GetKeyUp(KeyCode.W)&& transform.position.y < -6 && transform.position.y > -10&&transform.position.x>8&&transform.position.x<9)
        {
            Debug.Log("w pressed");
            Debug.Log(self.transform.position.y);
            Destroy(self);
            mainScript.howManyDestroyed++;
        }
        if (Input.GetKeyUp(KeyCode.D) && transform.position.y < -6 && transform.position.y > -10 && transform.position.x > 20 && transform.position.x < 21)
        {
            Debug.Log("d pressed");
            Debug.Log(self.transform.position.y);
            Destroy(self);
            mainScript.howManyDestroyed++;
        }
        if (Input.GetKeyUp(KeyCode.A) && transform.position.y < -6 && transform.position.y > -10 && transform.position.x > -8 && transform.position.x < -7)
        {
            Debug.Log("a pressed");
            Debug.Log(self.transform.position.y);
            Destroy(self);
            mainScript.howManyDestroyed++;
        }
        if (Input.GetKeyUp(KeyCode.S) && transform.position.y < -6 && transform.position.y > -10 && transform.position.x < -21&&transform.position.x>-23)
        {
            Debug.Log("s pressed");
            Debug.Log(self.transform.position.y);
            Destroy(self);
            mainScript.howManyDestroyed++;
        }
        if (transform.position.y < -10)
        {
            mainScript.lost = true;
        }
    }

}
