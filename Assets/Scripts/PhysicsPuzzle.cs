using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class PhysicsPuzzle : MonoBehaviour
{

    public Material redMat;
    public Material greenMat;
    public GameObject player;
    public List<GameObject> questItemList;
    public int questProgress;
    public string puzzleName;
    public UnityEvent puzzleComplete;

    private Renderer r;
    private PlayerController pc;

    // Start is called before the first frame update
    void OnEnable()
    {
        //For testing purposes
        r = GetComponent<Renderer>();

        pc = player.GetComponent<PlayerController>();

        //Always have the amount of required objects be the starting progress of the puzzle
        questProgress = questItemList.Count;

        //Add the QuestItem component script so we can set and check for QuestActive
        foreach(GameObject o in questItemList)
        {
            o.AddComponent<QuestItem>();
            QuestItem oq = o.GetComponent<QuestItem>();
            oq.setQuestActive();
            oq.questName = puzzleName;
        }

    }

    // Update is called once per frame
    void Update()
    {
        questCheck();
    }

    //Check to see if a/any puzzle items are inside the "goal"
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("puzzleItem") && !pc.carrying)
        {
            //Get the quest item component so we can check if the current item's quest is active
            QuestItem oqc = other.GetComponent<QuestItem>();
            //Make sure the collider has a quest component
            if(oqc != null)
            {
                if (oqc.questActive && oqc.questName == puzzleName)
                {
                    //Update the progress to completion, and disable the quest item
                    questProgress--;
                    oqc.setQuestInactive();
                }
            }
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("puzzleItem"))
    //    {
    //        //Debug material change
    //        r.material = redMat;
    //    }
    //}

    //Used to check if the puzzle is completed
    private void questCheck()
    {
        if(questProgress <= 0)
        {
            puzzleComplete.Invoke();

            //Debug material change
            r.material = greenMat;
        }
    }
}