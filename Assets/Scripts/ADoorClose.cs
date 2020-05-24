using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADoorClose : MonoBehaviour
{

    public AudioClip Close;

    void Start()
    {
        
    }


    private void OnEnable()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = Close;
        audio.Play();
    }

}
