﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Points : MonoBehaviour
{

    [SerializeField]
    private int _points = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _points = 50;
        } 
        else if (Input.GetKeyDown(KeyCode.W))
        {
            _points = 100;
        } 
        else if (Input.GetKeyDown(KeyCode.E))
        {
            _points = 0;
        }

        switch(_points)
        {
            case 50:
                Debug.Log("Points are 50!");
                break;
            case 100:
                Debug.Log("Points are 100");
                break;
            default:
                Debug.Log("No points :(");
                break;
        }
    }
}
