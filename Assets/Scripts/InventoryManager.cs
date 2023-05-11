using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject InvetoryMenu;
    private bool menuActivated;
    public ItemSlot[] itemSlot;

    private void Update()
    {
        if (Input.GetButtonDown("Inventory") && menuActivated)
        {
            Time.timeScale = 1;
            InvetoryMenu.SetActive(false);
            menuActivated = false;
        }

        else if (Input.GetButtonDown("Inventory") && !menuActivated)
        {
            Time.timeScale = 0;
            InvetoryMenu.SetActive(true);
            menuActivated = true;
        }
    }


    public void AddItem(string itemName, int quantity, Sprite itemSprite)
    {
        for (int i = 0; i < itemSlot.Length; i++)
        {
            if (itemSlot[i].isFull == false)
            {
                itemSlot[i].AddItem(itemName, quantity, itemSprite);
                return;
            }
        }

    }

    public void RemoveItem()
    {
        for (int i = itemSlot.Length - 1; i > 0; i--)
        {
            if (itemSlot[i].isFull == true)
            {
                itemSlot[i].RemoveItem();
            }
        }
    }

}
