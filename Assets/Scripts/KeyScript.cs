using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    [SerializeField] private InventoryScript.Item item;
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
        if (collision.tag == "Player" && collision.gameObject.transform.GetChild(0).GetComponent<InventoryScript>().CheckFreeSlot())
        {
            collision.gameObject.transform.GetChild(0).GetComponent<InventoryScript>().TakeItem(item);
            Destroy(gameObject);
        }
    }
}
