using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    //=====ITEM DATA=====//

    public string itemName;
    public int quantity;
    public Sprite itemSprite;
    public bool isFull;

    //====ITEM SLOT====//
    [SerializeField]
    private TMP_Text quantityText;

    [SerializeField]
    private Image itemImage;


    public GameObject selectedShader;
    public bool thisItemSelected;

    public void AddItem(string itemName, int quantity, Sprite itemSprite)
    {
        this.itemName = itemName;
        this.quantity = quantity;
        this.itemSprite = itemSprite;
        isFull = true;

        quantityText.text = quantity.ToString();
        quantityText.enabled = true;
        itemImage.sprite = itemSprite;
    }

    public void RemoveItem()
    {
        Debug.Log("item slot is called");

        itemName = null;
        quantity = 0;
        itemSprite = null;
        isFull = false;

        quantityText.text = quantity.ToString();
        quantityText.enabled = false;
        itemImage.sprite = null;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            OnLeftClick();
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            OnRightClick();
        }
    }

    public void OnLeftClick()
    {
        selectedShader.SetActive(true);
        thisItemSelected = true;
    }

    public void OnRightClick()
    {

    }
}
