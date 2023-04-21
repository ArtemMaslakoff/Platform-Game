using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    [Header("Condition 1")]
    [SerializeField] private GameObject[] gameObjectsCon1;
    [Header("Condition 2")]
    [SerializeField] private GameObject[] gameObjectsCon2;
    [Header("Condition 3")]
    [SerializeField] private GameObject[] gameObjectsCon3; 
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
        
    }
    void ChangeActive(GameObject[] gameObjects)
    {
        foreach (var obj in gameObjects)
        {
            obj.SetActive(!obj.activeInHierarchy);
        }
    }
}
