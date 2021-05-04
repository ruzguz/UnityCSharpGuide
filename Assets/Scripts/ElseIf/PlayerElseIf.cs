using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerElseIf : MonoBehaviour
{

    // Difficulty vars
    public int easyDifficulty = 0;
    public int mediumDifficulty = 1;
    public int hardDifficulty = 2;
    public int currentDifficulty;

    // Start is called before the first frame update
    void Start()
    {
        currentDifficulty = mediumDifficulty;
    }

    // Update is called once per frame
    void Update()
    {

        // Checking selected difficulty
        if (currentDifficulty == easyDifficulty) 
        {
            Debug.Log("You selected easy level");
        }
        else if (currentDifficulty == mediumDifficulty)
        {
            Debug.Log("You selected medium level");
        }
        else if (currentDifficulty == hardDifficulty) 
        {
            Debug.Log("You selected hard level");
        }
        else 
        {
            Debug.Log("Invalid Level");
        }
    }
}
