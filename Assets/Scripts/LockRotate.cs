﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class LockRotate : MonoBehaviour
{
    [SerializeField]
    private Image MouseImage;

    public static event Action<string, int> Rotated = delegate { };

    private bool coroutineAllowed;

    private int numberShown;

    AudioSource Click;


    private void Start()
    {
        coroutineAllowed = true;
        numberShown = 0;
        Click = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if (coroutineAllowed)
        {
            StartCoroutine("RotateWheel");
            Click.Play(0);
        }
        
    }

    private IEnumerator RotateWheel()
    {
        coroutineAllowed = false;

        for (int i = 0; i <= 11; i++)
        {
            transform.Rotate(0f, 0f, -3f);
            yield return new WaitForSeconds(0.01f);
        }

        coroutineAllowed = true;

        numberShown -= 1;

        if(numberShown < 0)
        {
            numberShown = 9;
        }

        Rotated(name, numberShown);
    }

    private void OnMouseOver()
    {
        MouseImage.enabled = true;
    }

    private void OnMouseExit()
    {
        MouseImage.enabled = false;
    }


}
