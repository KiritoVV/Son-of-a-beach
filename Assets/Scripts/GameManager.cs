using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<string> inventory;
    Camera cam;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            
            if(Physics.Raycast(ray,out hitInfo))
            {
                if(hitInfo.collider.gameObject.tag == "Pickable")
                {
                    inventory.Add(hitInfo.collider.gameObject.name);
                    Debug.Log(hitInfo.collider.gameObject.name + "Picked !");
                    Destroy(hitInfo.collider.gameObject);
                }
            }
        }
    }
}
