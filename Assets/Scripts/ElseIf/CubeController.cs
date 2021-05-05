using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Create a script when that when you hit space key you score 10 points
    // When score is greather than 50 turn the color of the cube to green
    // The cube gonna start red as default

    public GameObject cube;
    public int points = 0;
    private Renderer _cubeRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _cubeRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Detect sapce key
        // If users hits space key
        // then score 10 points
        if (Input.GetKeyDown(KeyCode.Space))
        {
            points += 10;
        }


        // if points is greather than 50 
        // then change cube color to green
        if (points >= 50) 
        {
            _cubeRenderer.material.color = Color.green;
        } 
    }
}
