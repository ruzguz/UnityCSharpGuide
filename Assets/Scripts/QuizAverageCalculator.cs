using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizAverageCalculator : MonoBehaviour
{
    // 5 quiz
    // Create a program that calculates random quiz values and prints the average

    public float quiz1, quiz2, quiz3, quiz4, quiz5;
    private float average;

    // Start is called before the first frame update
    void Start()
    {
        // Assing random values to each quiz
        quiz1 = Random.Range(0f, 100f);
        quiz2 = Random.Range(0f, 100f);
        quiz3 = Random.Range(0f, 100f);
        quiz4 = Random.Range(0f, 100f);
        quiz5 = Random.Range(0f, 100f);

        // Caldulate the average and print it 
        average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;
        Debug.Log("Quiz results: ");
        Debug.Log("Quiz #1 = " + quiz1);
        Debug.Log("Quiz #2 = " + quiz2);
        Debug.Log("Quiz #3 = " + quiz3);
        Debug.Log("Quiz #4 = " + quiz4);
        Debug.Log("Quiz #5 = " + quiz5);
        Debug.Log("Quiz grades average: " + average.ToString("F2"));

    }
}
