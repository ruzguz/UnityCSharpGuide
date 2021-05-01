using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Variable to store name
    public string  playerName = "Rusben"; 
    // Variable to store Age
    public int age = 25;
    // Variable to store speed
    public float speed = 5f;
    // Health variable
    public int health = 3;
    // Score variable 
    // Check is all keys were collected
    public bool hasAllKeys = false;
    // Ammo count vairable 
    public int ammo = 30;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Name: " + playerName);
        Debug.Log("Age: " + age);
        Debug.Log("Speed: " + speed);
        Debug.Log("Health: " + health);
        Debug.Log("Player has all keys?: " + hasAllKeys);
        Debug.Log("Ammo: " + ammo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
