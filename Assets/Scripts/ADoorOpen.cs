using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADoorOpen : MonoBehaviour
{
    public AudioClip Open;

    void Start()
    {
     
    }

    private void OnEnable()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = Open;
        audio.Play();
    }


}
