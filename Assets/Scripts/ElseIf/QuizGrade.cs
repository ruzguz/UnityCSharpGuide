using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGrade : MonoBehaviour
{

    // else-if challenge
    // Calculate the grade AVG
    // Print the grade AVG base on the scenario

    // if grade average is greather than 90 print A
    // if grade average is greather than 80 but less than 90 print B
    // if grade average is greather than 70 but less than 80 print C
    // if grade average id less than 70 print F

    public int quiz1, quiz2, quiz3, quiz4, quiz5;
    [SerializeField] private int _average;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // calculating the quiz grade average
        _average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;

        // Check grades
        if (_average >= 90) 
        {
            Debug.Log("You got an A");
        }
        else if (_average >= 80 && _average < 90)
        {
            Debug.Log("You got a B");
        }
        else if (_average >= 70 && _average < 80)
        {
            Debug.Log("You got a C");
        } 
        else 
        {
            Debug.Log("You got a F");
        }
           
    }
}
