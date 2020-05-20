using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    /////////////////////
    //PUBLIC VARIABLES//
    ////////////////////
    public float sensitivity = 100f;
    public GameObject playerBody;

    /////////////////////
    //PRIVATE VARIABLES//
    ////////////////////
    private float yRotation;
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        //Lock cursor inside play area
        Cursor.lockState = CursorLockMode.Locked;
        playerTransform = playerBody.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensitivity * Time.deltaTime;


        if(playerBody.GetComponent<PlayerController>().canMove)
        {
            //Negative y so the controls are not inverted
            yRotation -= mouseY;
            //Clamp the y value so you can't rotate all the way around and break your neck
            yRotation = Mathf.Clamp(yRotation, -90f, 90f);

            //Rotate player
            transform.localRotation = Quaternion.Euler(yRotation, 0f, 0f);
            playerTransform.Rotate(Vector3.up * mouseX);
        }
    }
}
