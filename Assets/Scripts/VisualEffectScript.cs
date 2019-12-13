﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualEffectScript : MonoBehaviour
{
    
    [Tooltip("the time after object will be destroyed")]
    public float destructionTime;

    private void OnEnable()
    {
        StartCoroutine(Destruction()); //launching the timer of destruction
    }

    IEnumerator Destruction() //wait for the estimated time, and destroying or deactivating the object
    {
        yield return new WaitForSeconds(destructionTime); 
        Destroy(gameObject);
    }
}
