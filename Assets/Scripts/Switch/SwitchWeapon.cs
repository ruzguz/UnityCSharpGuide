using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    public int weaponID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Selecting weapon
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponID = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            weaponID = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) 
        {
            weaponID = 3;
        }

        // Print weapong
        switch(weaponID) 
        {
            case 1:
                Debug.Log("Gun");
                break;
            case 2:
                Debug.Log("Knife");
                break;
            case 3:
                Debug.Log("Machine Gun");
                break;
            default:
                Debug.Log("No weapon");
                break;
        }
    }
}
