using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndTrigger : MonoBehaviour
{

    public int boxCount = 0;
    // public GameObject reach1;
    // public GameObject reached1;
    // public GameObject reach2;
    // public GameObject reached2;
    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;

    public SheepManagment sheepManagment;

    public GameObject completeLevelUI;

    private void Update()
    {
        if (sheepManagment.sheepCount >= sheepManagment.maxSheep)
        {
            Text1.text = "Reach " + IntToWord(boxCount + 1) +" fence";

            if (boxCount >= 1)
            {
                Text2.text = "Reached " + IntToWord(boxCount) +" fence";
            }
        }


        if (transform.childCount == boxCount)
        {
            Text1.enabled = false;
            Debug.Log("Level Gehaald!");
            CompleteLevel();
        }
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    private string IntToWord(int i)
    {
        switch (i)
        {
            case 1: return "first"; 
            case 2: return "second";
            case 3: return "third";
            case 4: return "fourth";
            case 5: return "fifth";
            case 6: return "sixth";
            case 7: return "seventh"; 
            case 8: return "eighth";
            case 9: return "nineth"; 
            default: return "Number not in IntToWord function"; 
        }

    }

}
