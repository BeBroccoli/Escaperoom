using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookcase : MonoBehaviour
{
    [SerializeField]
    GameObject Bookshelf;

    private Animator Bookanim;

    // Start is called before the first frame update
    void Start()
    {
        Bookanim = Bookshelf.GetComponent<Animator>();
    }

    void HitByRay()
    {
        Bookanim.SetBool("BookshelfAktivation", true);
    }


}
