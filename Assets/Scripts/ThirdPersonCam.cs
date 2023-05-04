using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{
    [Header("Reference")]
    public Transform orientation;
    public Transform player;
    public Transform playerObj;
    public Rigidbody rb;

    public float rotationSpeed;

    public CameraStyle currentStyle;

    public Transform combatLookAt;

    public enum CameraStyle
    {
        Basic,
        Topdown
    }

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        // rotate orientation 
        Vector3 viewdir = player.position - new Vector3(transform.position.x, player.position.y, transform.position.z);
        orientation.forward = viewdir.normalized;

        // rotate player object
        if(currentStyle == CameraStyle.Basic)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            Vector3 inputDir = orientation.forward * verticalInput + orientation.right * horizontalInput;

            if (inputDir != Vector3.zero)
            {
                playerObj.forward = Vector3.Slerp(playerObj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
                //playerObj.localRotation = new Vector3(0, playerObj.localRotation.y, playerObj.localRotation.z);
            }
        }
    }
}
