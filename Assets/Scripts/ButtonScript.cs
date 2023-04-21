using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [Header("Objects")]
    [SerializeField] private GameObject[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ChangeActive();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ChangeActive();
    }
    void ChangeActive()
    {
        foreach (var obj in gameObjects)
        {
            obj.SetActive(!obj.activeInHierarchy);
        }
    }
}
