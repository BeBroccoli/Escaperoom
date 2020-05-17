using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockControl : MonoBehaviour
{
    private int[] result, correctCombination;
    private void Start()
    {
        result = new int[] { 0, 0, 0 };
        correctCombination = new int[] { 8, 2, 6 };
        LockRotate.Rotated += CheckResults; 
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
        }
    }

    private void OnDestroy()
    {
        LockRotate.Rotated -= CheckResults;
    }
}
