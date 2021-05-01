using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Every item has a name, description, image icon, attack strength 
    public string itemName = "Sword";
    public string description = "Kings Arthur supreme sword";
    public Sprite icon;
    public int attackStrength = 30;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Item: " + itemName + " - " + description + " - Attack: " + attackStrength);
    }

}
