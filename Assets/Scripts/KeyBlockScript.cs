using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBlockScript : MonoBehaviour
{
    [SerializeField] private InventoryScript.Item item;

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
        if (collision.tag == "Player" && collision.gameObject.transform.GetChild(0).GetComponent<InventoryScript>().IsItemInInventory(item))
        {
            collision.gameObject.transform.GetChild(0).GetComponent<InventoryScript>().DeleteItem(item);
            Destroy(gameObject);
            foreach (var extraBlock in gameObjects)
            {
                Destroy(extraBlock);
            }
        }
    }
}
