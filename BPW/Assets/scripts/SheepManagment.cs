using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepManagment : MonoBehaviour
{
    public int maxSheep;
    public int sheepCount;
    public GameObject boxTriggers;

    private void Update()
    {
        if(sheepCount >= maxSheep)
        {
            boxTriggers.SetActive(true);
        }
    }
}
