using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float sensitivity = 100f;
    public Transform playerBody;

    private float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Lock cursor inside play area
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensitivity * Time.deltaTime;

        //Negative y so the controls are not inverted
        xRotation -= mouseY;
        //Clamp the y value so you can't rotate all the way around and break your neck
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Rotate player
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        //RotateView();
    }

    //private void RotateView()
    //{
    //    //Negative y so the controls are not inverted
    //    xRotation -= mouseY;
    //    //Clamp the y value so you can't rotate all the way around and break your neck
    //    xRotation = Mathf.Clamp(xRotation, -90f, 90f);

    //    //Rotate player
    //    transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    //    playerBody.Rotate(Vector3.up * mouseX);
    //}
}
