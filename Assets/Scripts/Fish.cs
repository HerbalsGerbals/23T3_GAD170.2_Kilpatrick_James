using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class Fish : MonoBehaviour
{
    private string fishSpecies;
    private int dollarValue;
    private float fishLength;
    public string[] inventory = new string[5] { "Sea Bass", "Horse Mackerel", "Red Snapper", "Barred Knifejaw", "Shark" };
    public int minInt = 5;
    public int maxInt = 50;
    public float minFloat = 5;
    public float maxFloat = 50;
    public Aquarium aquarium;
    public float cloneLength;
    public bool fishEaten;
    
    public string GetFish()
    {
        return fishSpecies;
    }

    public int GetValue()
    {
        return dollarValue;
    }

    public float GetLength()
    {
       
        return fishLength;
        
    }
    public void SetIntialStats(string[] newFish, int newValue, float newLength)
    {
        fishSpecies = newFish[Random.Range(0,newFish.Length)];
        dollarValue = newValue;
        fishLength = newLength;
        
    }
     public void FishEaten()
    {
        if(aquarium !=null)
        {
            aquarium.RemoveFish(this);
        }
        Destroy(gameObject);
    }
    public void Start()
    {
        SetIntialStats(inventory = new string[5] { "Sea Bass", "Horse Mackerel", "Red Snapper", "Barred Knifejaw", "Shark" }, Random.Range(minInt, maxInt), Random.Range(minFloat, maxFloat));

    }

}