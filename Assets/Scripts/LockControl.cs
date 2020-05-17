using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LockControl : MonoBehaviour
{
    private int[] result, correctCombination;
    [SerializeField]
    GameObject Item;

    private Animator Anim;
    public string animationBool;
    public UnityEvent OpenCase;

    private void Start()
    {
        result = new int[] { 0, 0, 0 };
        correctCombination = new int[] { 8, 2, 6 };
        LockRotate.Rotated += CheckResults; 
    }

    void OnEnable()
    {
        if (Item != null)
        {
            Anim = Item.GetComponent<Animator>();
        }
    }

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

    private void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {
            case "Wheel Digit Left":
                result[0] = number;
                break;

            case "Wheel Digit Mid":
                result[1] = number;
                break;

            case "Wheel Digit Right":
                result[2] = number;
                break;
        }
        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2])
        {
            Debug.Log("Gottem");
            OpenCase.Invoke();
        }
    }

    private void OnDestroy()
    {
        LockRotate.Rotated -= CheckResults;
    }
}
