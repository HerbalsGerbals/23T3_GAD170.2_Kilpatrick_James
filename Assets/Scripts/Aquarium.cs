using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Aquarium : MonoBehaviour
{
    public List<int> fish = new List<int>();
    public string[] inventory = new string[5] { "Sea Bass", "Horse Mackerel", "Red Snapper", "Barred Knifejaw", "Shark" };
    public void Start()
    {
        fish.Add(1);
        AddNewFish(1);
    }
    void DisplayingNewFish()
    {

    }
    void AddNewFish(int newfish)
    {
        fish.Add(newfish);
        Debug.Log("You have caught a new fish!");
    }

    void SortFish()
    {

    }
}
    

    



