using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsPuzzle : MonoBehaviour
{

    public Material redMat;
    public Material greenMat;
    public GameObject player;
    public List<GameObject> questItemList;
    public int questProgress;

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
        }

    }

    // Update is called once per frame
    void Update()
    {
        questCheck();
    }

    //Check to see if a/any puzzle items are inside the "goal"
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("puzzleItem"))
        {
            //Get the quest item component so we can check if the current item's quest is active
            QuestItem oqc = other.GetComponent<QuestItem>();
            if (oqc.questActive)
            {
                //Update the progress to completion, and disable the quest item
                questProgress--;
                oqc.setQuestInactive();
            }
        }
    }

    //Used to check if the puzzle is completed
    private void questCheck()
    {
        if(questProgress <= 0)
        {
            print("Well Done!");
        }
    }



    #region TESTING
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("puzzleItem") && !pc.carrying && questProgress <= 0)
        {
            r.material = greenMat;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("puzzleItem"))
        {
            r.material = redMat;
        }
    }
}

#endregion