using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        GameEventManager.Subscribe("hello",showName);
    }

    void OnDisable()
    {
        GameEventManager.Unsubscribe("hello",showName);
    }

    void showName()
    {
        Debug.Log(gameObject.name + " is showing name");
    }

    // Update is called once per frame
    void Update()
    {
    }
}