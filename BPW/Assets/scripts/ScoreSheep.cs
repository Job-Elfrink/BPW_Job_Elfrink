using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSheep : MonoBehaviour
{
    public SheepManagment sheepManagement;
    public TextMeshProUGUI score;

    private void Update()
    {
        score.text = "Sheep paralyzed: " + sheepManagement.sheepCount + " / " + sheepManagement.maxSheep;
    }


}
