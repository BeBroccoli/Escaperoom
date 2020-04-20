using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public CharacterController controller;
    public float gravity = -9.81f;
    public Camera cam;

    private float pickupLength = 3;
    private Vector3 movement;
    private Vector3 velocity;
    private GameObject carriedObject;
    private bool carrying;
    private float smooth = 5f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }



    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        //Apply gravity because character controllers don't use physics
        if(!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity*Time.deltaTime);
        } else if (controller.isGrounded)
        {
            velocity.y = -1.0f;
        }



        
        if (carrying)
        {
            carry(carriedObject);
            if (Input.GetMouseButtonDown(0))
            {
                dropObject();
            }

            //Move held object away or closer when scrolling the mousewheel
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                pickupLength += 0.5f;
                pickupLength = Mathf.Clamp(pickupLength, 2, 6);
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                pickupLength -= 0.5f;
                pickupLength = Mathf.Clamp(pickupLength, 2, 6);
            }

        }
        else
        {
            itemPickup();
        }
    }


    #region ItemPickup
    private void itemPickup()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Draw a ray to see if we hit a physics object
            int layerMask = 1 << 10;
            RaycastHit hit;
            if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, pickupLength, layerMask))
            {
                //Debug.DrawRay(cam.transform.position, cam.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                carrying = true;
                carriedObject = hit.rigidbody.gameObject;
            }
        }
    }

    private void carry (GameObject o)
    {
        Rigidbody rb = o.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.freezeRotation = true;
        //Lerp the position with delta time to smooth the movement of the object. Also helps with clipping through other objects
        o.transform.position = Vector3.Lerp(o.transform.position, cam.transform.position + cam.transform.forward * pickupLength, Time.deltaTime * smooth);
        //Reset velocity otherwise the carriedObject would freak out
        rb.velocity = new Vector3(0,0,0);
    }

    private void dropObject()
    {
        carrying = false;
        carriedObject.GetComponent<Rigidbody>().useGravity = true;
        carriedObject.GetComponent<Rigidbody>().freezeRotation = false;
        carriedObject = null;
        pickupLength = 3.0f;
    }

    #endregion

}
