using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour
{

    // Script to increment and decrement player speed

    public int speed = 0;
    

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        // Moving cube
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // if press A then increase the speed
        // else if press S drecrease the speed

        if (Input.GetKeyDown(KeyCode.A))
        {
            speed += 2;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            speed = Mathf.Clamp(speed - 2, 0, int.MaxValue);
        }

        // if speed is greather than 20 then print slow down
        // else if speed is equals to 0 then print speed up

        if (speed > 20)
        {
            Debug.Log("Slow Down");
        }
        else if (speed == 0)
        {
            Debug.Log("Speed Up!!!");
        }
    }
}
