using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADoorOpen : MonoBehaviour
{
    AudioSource Audio;

    void Start()
    {
     
    }

    private void OnEnable()
    {
        Audio = GetComponent<AudioSource>();
        Audio.Play(0);
    }


}
