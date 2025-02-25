using System.Collections;
using System.Collections.Generic;
using UnityEngine;

tatementsInt.cs

using UnityEngine;

public class StatementsInt : MonoBehaviour
{
    void Start()
    {
        // Test values for the conditions
        int score1 = 70;
        int score2 = 55;
        int score3 = 85;
        int score4 = 100;

        // Simple if statement
        if (score1 > 60)
        {
            Debug.Log("passed");
        }

        // If-else statement
        if (score2 > 60)
        {
            Debug.Log("passed");
        }
        else
        {
            Debug.Log("try again");
        }

        // Complex if-else if-else statement
        // Note: I believe there's a typo in the assignment, as it has the same condition twice
        // I'll implement what I think was intended
        if (score3 > 60 && score3 < 75)
        {
            Debug.Log("passed");
        }
        else if (score3 >= 75 && score3 < 100)
        {
            Debug.Log("passed well");
        }
        else if (score3 == 100)
        {
            Debug.Log("passed great");
        }
        else
        {
            Debug.Log("try again");
        }

        // Test the perfect score condition
        if (score4 > 60 && score4 < 75)
        {
            Debug.Log("passed");
        }
        else if (score4 >= 75 && score4 < 100)
        {
            Debug.Log("passed well");
        }
        else if (score4 == 100)
        {
            Debug.Log("passed great");
        }
        else
        {
            Debug.Log("try again");
        }
    }
}
