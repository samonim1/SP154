using System.Collections;
using System.Collections.Generic;
using UnityEngine;

StatementsString.cs

using UnityEngine;

public class StatementsString : MonoBehaviour
{
    void Start()
    {
        string yourName = "Your Name"; // Replace with your actual name
        
        string inputName1 = "Your Name"; // This should match
        string inputName2 = "Someone Else"; // This should not match
        
        // Compare with your name
        if (inputName1 == yourName)
        {
            Debug.Log("You're " + yourName);
        }
        else
        {
            Debug.Log("You're not " + yourName);
        }
        
        // Another comparison with a different value
        if (inputName2 == yourName)
        {
            Debug.Log("You're " + yourName);
        }
        else
        {
            Debug.Log("You're not " + yourName);
        }
    }
}


