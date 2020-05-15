using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;


public class UseObject : MonoBehaviour
{
    [SerializeField]
    GameObject Item;
    [SerializeField]
    private Image customImage;

    public string animationBool;
    public UnityEvent onUse;

    private Animator Anim;

    // OnEnable is called when the object is enabled, or at start if it starts as enabled
    void OnEnable()
    {
        if(Item != null)
        {
            Anim = Item.GetComponent<Animator>();
        }
    }

    //Call this method when hit by ray in player script
    void HitByRay()
    {
        onUse.Invoke();
    }

    //Sets animation bool of Item. Called when used in the onUse unity event
    //Creating a method for this since you can't set animation bool through pure unity event
    public void setAnimBool()
    {
        if (!Anim.GetBool(animationBool))
        {
            Anim.SetBool(animationBool, true);
        }

        else if (Anim.GetBool(animationBool))
        {
            Anim.SetBool(animationBool, false);
        }
    }

    private void OnMouseOver()
    {
        Debug.Log("HEY");
        customImage.enabled = true;
    }

    private void OnMouseExit()
    {
        customImage.enabled = false;
    }
}
