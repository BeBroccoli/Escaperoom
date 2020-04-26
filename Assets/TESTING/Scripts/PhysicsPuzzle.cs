﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsPuzzle : MonoBehaviour
{

    public Material redMat;
    public Material greenMat;
    public GameObject player;
    public List<GameObject> questItems;

    private Renderer r;
    private PlayerController pc;

    // Start is called before the first frame update
    void OnEnable()
    {
        r = GetComponent<Renderer>();
        pc = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //for (int i = 0; i <= questItems.Count; i++)


    #region TESTING
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("puzzleItem") && !pc.carrying)
        {
            r.material = greenMat;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("puzzleItem"))
        {
            r.material = redMat;
        }
    }
}

#endregion