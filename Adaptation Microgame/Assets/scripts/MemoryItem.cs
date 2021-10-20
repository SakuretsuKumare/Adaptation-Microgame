using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryItem : MonoBehaviour
{
    public int orderNum;
    private Memory mem;
    private GameObject scriptMule;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        scriptMule = GameObject.Find("ScriptMule");
        mem = scriptMule.GetComponent<Memory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        if (mem.getReadyToPlay()) 
        { 
            if (orderNum == mem.getOrder())//once again, not sure what is going on, but this is the only way I could make the game function.
            {
                Destroy(self);
                mem.OneDestroyed();
                if (orderNum == mem.getNumberSpawned())
                {
                    mem.won = true;
                }
            }
            else
            {
                mem.lost = true;
                Debug.Log(orderNum);
            }
        }
    }
    public void SetOrderNum(int order)//to determine what order they need to be clicked in
    {
        orderNum = order;
    }
}
