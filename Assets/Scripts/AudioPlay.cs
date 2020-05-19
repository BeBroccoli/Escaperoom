using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    AudioSource SFX;

    void Start()
    {
        SFX = GetComponent<AudioSource>();
        SFX.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
