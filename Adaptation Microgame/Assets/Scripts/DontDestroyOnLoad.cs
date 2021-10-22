using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This code was used from https://www.youtube.com/watch?v=BKCsH8mQ-lM

public class DontDestroyOnLoad : MonoBehaviour
{
    // Keeps the object going even to the next scene - Doesn't destroy the object
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}