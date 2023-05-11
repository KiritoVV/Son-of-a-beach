using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bins : MonoBehaviour
{

    private InventoryManager inventoryManager;

    public TextMeshProUGUI Interact;
    private bool isInTrigger;

    
    private void Update()
    {
        if (isInTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                FindObjectOfType<InventoryManager>().RemoveItem();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isInTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isInTrigger = false;
        }
    }
}
