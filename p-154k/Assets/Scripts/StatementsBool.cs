using System.Collections;
using System.Collections.Generic;
using UnityEngine;

StatementsBool.cs

using UnityEngine;

public class StatementsBool : MonoBehaviour
{
    void Start()
    {
        bool student1 = true;
        bool student2 = false;
        
        // Compare with true
        if (student1 == true) // or simply: if (student1)
        {
            Debug.Log("passed");
        }
        else
        {
            Debug.Log("try again");
        }
        
        // Compare with false
        if (student2 == false) // or simply: if (!student2)
        {
            Debug.Log("try again");
        }
        else
        {
            Debug.Log("passed");
        }
    }
}