using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Aquarium : MonoBehaviour
{
    public string[] inventory = new string[5] { "Sea Bass", "Horse Mackerel", "Red Snapper", "Barred Knifejaw", "Shark" };
    public List<Fish> fishs = new List<Fish>();
    public GameObject fishPrefab;
    public Fish fish;
    public float fishlength;
    public bool fishEaten;
    

    public void Start()
    {
        CreateNewFish();
        GameObject fishlength = FindObjectOfType<GameObject>();
    }

    void CreateNewFish()
    {
        GameObject newfish = Instantiate(fishPrefab);
        Debug.Log("You have caught a new fish!");
        Debug.Log("would you like to keep it?" +" Press Y to keep it or N to throw it back in the water");
        
    }

    void AddCreatedFish()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("Fish was kept");
            fishs.Add(fish);
            CreateNewFish();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("Fish was thrown back into the water");
            
            fish.FishEaten();
            CreateNewFish();
        }
        //If fish is twice as large smaller fish is eaten
        foreach (var fish in fishs)
        {
            fishlength = fish.gameObject.GetComponent<fishlength>();
        }
        
        //Dollar value goes up or down depending on fish amount
    }
    public void RemoveFish(Fish fishToRemove)
    {
        fishs.Remove(fishToRemove);
    }
    
    public void Update()
    {
        AddCreatedFish();
    }
}