using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatement : MonoBehaviour
{

    [SerializeField]
    private int _difficulty = 0; // easy = 0, medium = 1, hard = 2

    // Start is called before the first frame update
    void Start()
    {
        _difficulty = Random.Range(0,3);        
    }

    // Update is called once per frame
    void Update()
    {
        switch(_difficulty)
        {
            case 0:
                Debug.Log("Easy level!");
                break;
            case 1:
                Debug.Log("Medium level :O");
                break;
            case 2:
                Debug.Log("Hard level >:)");
                break;
            default:
                Debug.Log("Invalid Level >:(");
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            _difficulty = Random.Range(0,3);
        }
    }
}
