using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIfStatement : MonoBehaviour
{
    public int myAge = 16;
    private int _legalAgeToDrive = 16;

    // Start is called before the first frame update
    void Start()
    {
        // if my age is greather or equal than 16 (legal age to drive)
        // then print "Hey you can drive"
        // else
        // print "you CAN NOT drive"

        if (myAge >= _legalAgeToDrive) 
        {
            Debug.Log("Hey!!! You can drive");
        }
        else 
        {
            Debug.Log("You CAN NOT drive");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
