using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /////////////////////
    //PUBLIC VARIABLES//
    ////////////////////
    public float speed = 5.0f;
    public float gravity = -9.81f;
    public bool canMove;
    public bool carrying;

    public CharacterController controller;
    
    public Camera cam;


    /////////////////////
    //PRIVATE VARIABLES//
    /////////////////////
    private float pickupLength = 3;
    private float smooth = 5f;

    private Vector3 movement;
    private Vector3 velocity;
    private GameObject carriedObject;




    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        controller = GetComponent<CharacterController>();
    }



    // Update is called once per frame
    void Update()
    {
        //Player movement - limited by variable so we can control held objects
        if(canMove)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;
            controller.Move(move * speed * Time.deltaTime);
        }

    }

   
    void FixedUpdate()
    {
        //Fake gravity because character controllers don't use physics
        if(!controller.isGrounded)
        {
            velocity.y += gravity * Mathf.Pow(Time.deltaTime, 2);
            controller.Move(velocity);
        } else if (controller.isGrounded)
        {
            //Always apply a small force downwards since sometimes it bugs out and sets isGrounded before actually being on the ground
            velocity.y = -1.0f;
        }


        if (carrying)
        {
            carry(carriedObject);
            if (Input.GetMouseButtonDown(0))
            {
                dropObject();
            }
            
            //Use scrollwheel to push or pull the held object
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

         
            if (Input.GetMouseButton(1))
            {
                rotateObject(carriedObject);
            }
            //Since the mouse button input is a boolean, it can be used to determine the canMove variable, so you can't move while rotating objects
            canMove = !Input.GetMouseButton(1);

        }
        //Make sure the player can move again after dropping object, and check for pickups again
        else if(!carrying)
        {
            useItem();
            canMove = true;
            itemPickup();
        }
    }

    private void itemPickup()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Raycast and look for a collider with the physicsItem layer (layer 10)
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
        //Lerp with delta time for smooth movement on the carried object
        o.transform.position = Vector3.Lerp(o.transform.position, cam.transform.position + cam.transform.forward * pickupLength, Time.deltaTime * smooth);
        //The held object had glitchy behaviour if hit by other objects while being held. To fix this we reset the velocity
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

    private void rotateObject(GameObject o)
    {
        canMove = false;
        Rigidbody rb = o.GetComponent<Rigidbody>();
        //Unfreeze the object so we can apply torque
        rb.freezeRotation = false;

        float turnX = Input.GetAxis("Mouse X");
        float turnY = Input.GetAxis("Mouse Y");
        float torque = 1000;
        rb.AddTorque(Vector3.up * torque * -turnX * Time.deltaTime);
        rb.AddTorque(Vector3.right * torque * turnY * Time.deltaTime);
    }

    private void useItem()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Raycast and look for a collider with the physicsItem layer (layer 10)
            int layerMask = 1 << 11;
            RaycastHit hit;
            if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, pickupLength, layerMask))
            {
            
                hit.transform.SendMessage("HitByRay");
            }

          

        }


    }

}
