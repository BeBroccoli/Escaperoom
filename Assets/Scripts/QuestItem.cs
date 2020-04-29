using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour
{

    public bool questActive;
    public string questName;



    public void setQuestActive()
    {
        questActive = true;
    }

    public void setQuestInactive()
    {
        questActive = false;
    }
}
