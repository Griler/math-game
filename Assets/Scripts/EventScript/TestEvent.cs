using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TestEvent : MonoBehaviour
{
    private void Awake()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameEventManager.Raise("hello");
        }
    }
}
