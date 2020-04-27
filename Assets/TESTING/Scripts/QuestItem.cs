using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour
{

    public bool questActive;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setQuestActive()
    {
        questActive = true;
    }

    public void setQuestInactive()
    {
        questActive = false;
    }
}
