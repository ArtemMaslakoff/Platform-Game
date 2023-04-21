using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    [SerializeField] private int money = 0;

    [SerializeField] private int maxNumberOfItems = 3;
    [SerializeField] private int numberOfItems = 0;

    [SerializeField] private Item[] items;

    public enum Item
    {
        FREE,
        GOLDENKEY,
        SILVERKEY
    }

    // Start is called before the first frame update
    void Start()
    {
        items = new Item[maxNumberOfItems];
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
    int GetMoney()
    {
        return money;
    }
    public void TakeMoney(int newMoney)
    {
        money += newMoney;
    }

    int GetItem()
    {
        return money;
    }
    public void TakeItem(Item NewItem)
    {
        if (numberOfItems != maxNumberOfItems)
        {
            items[numberOfItems] = NewItem;
            numberOfItems++;
        }
    }
    public void DeleteItem(Item item)
    {
        bool isDeleted = false;
        for (int i = 0;i < numberOfItems;i++)
        {
            if (isDeleted)
            {
                items[i - 1] = items[i];
            }  
            else
            {
                if (items[i] == item)
                {
                    isDeleted = true;
                }
                items[i] = items[i];
            }
        }
        items[numberOfItems - 1] = Item.FREE;
        numberOfItems --;
    }
    public bool CheckFreeSlot()
    {
        if (maxNumberOfItems == numberOfItems)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public bool IsItemInInventory(Item item)
    {
        for (int i = 0; i < numberOfItems; i++)
        {
            if (items[i] == item)
            {
                return true;
            }
        }
        return false;
    }
}
