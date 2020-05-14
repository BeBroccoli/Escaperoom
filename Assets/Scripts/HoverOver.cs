using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverOver : MonoBehaviour
{
    [SerializeField]
    private Image customImage;

    void HitByRay()
    {
        customImage.enabled = true;
    }
}
