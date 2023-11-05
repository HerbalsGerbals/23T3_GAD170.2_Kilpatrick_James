using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Fish : MonoBehaviour
{
    private string fishSpecies;
    private int dollarValue;
    private float fishLength;
    public string[] inventory = new string[5] {"Sea Bass", "Horse Mackerel", "Red Snapper", "Barred Knifejaw", "Shark"};
public string GetFish()
    {
        return fishSpecies;
        
    }
    public void SetIntialStats(string newFish, int newValue,  float newLength)
    {
        fishSpecies = newFish;
        dollarValue = newValue;
        fishLength = newLength;
    }
    public string GetFishType()
    {
        return fishSpecies;
    }
    public void Start()
    {
        Debug.Log("The fish is " + inventory[Random.Range(0, inventory.Length)]);
        GetFish();
        SetIntialStats("Fish", 3, 4);
    }
}
