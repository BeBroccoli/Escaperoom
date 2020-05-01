using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseAnimObject : MonoBehaviour
{
    [SerializeField]
    GameObject Item;

    private Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = Item.GetComponent<Animator>();
    }

    void HitByRay()
    {
        if (!Anim.GetBool("active"))
        {
            Anim.SetBool("active", true);
        }

        else if (Anim.GetBool("active"))
        {
            Anim.SetBool("active", false);
        }
    }


}
