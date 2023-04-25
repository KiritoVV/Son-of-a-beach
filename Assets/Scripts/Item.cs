using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    

public class Item : MonoBehaviour
{
    [SerializeField]
    private string itemName;

    [SerializeField]
    private int quantity;

    [SerializeField]
    private Sprite sprite;

    private InventoryManager inventoryManager;

    public TextMeshProUGUI Interact;
    private bool isInTrigger;

    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();

       
    }

    private void Update()
    {
        if(isInTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                inventoryManager.AddItem(itemName, quantity, sprite);
                Destroy(gameObject);
                Interact.gameObject.SetActive(false);
            }
        }
    }

    /*private void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            inventoryManager.AddItem(itemName, quantity, sprite);
            Destroy(gameObject);
        }
    }*/

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            Interact.gameObject.SetActive(true);
            //isInTrigger = true;
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("I picked it up");
                inventoryManager.AddItem(itemName, quantity, sprite);
                Destroy(gameObject);
                Interact.gameObject.SetActive(false);
            }
        }
        else
        {
            Interact.gameObject.SetActive(true);
            isInTrigger = false;
        }
    }
}
