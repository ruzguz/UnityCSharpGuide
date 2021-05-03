using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{

    /*
     * Create a TipCalculator 
     * Bill (amount)
     * Tip percentage (20% or given by the user) 
     * Total = bill + bill * (tip/100)
     */
    public float bill = 49.99f;
    public int tip = 20;
    private float total;

    // Start is called before the first frame update
    void Start()
    {
        total =  bill + bill * (tip/100f);
        Debug.Log("Your bill is: " + bill + " and your tip is: " + tip + ", so you owe: " + total);
    }

}
