using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIfStatement : MonoBehaviour
{
    // Overview
    public int myAge = 16;
    private int _legalAgeToDrive = 16;

    // Challenge #1
    public int points = 0;

    // Challenge #4 
    public bool hasSaidMessage = false;

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
        
        // Challenge #2: 
        // if user press space key 
        // then add 10 points

        if (Input.GetKeyDown("space"))
        {
            points += 10;
        }

        // Challenge #3 
        // if points is greather or equals than 50 AND has not said message 
        // print you are the boss

        if (points >= 50 && !hasSaidMessage) 
        {
            Debug.Log("You are the BOSS!!!");
            hasSaidMessage = true;
        }

    }
}
