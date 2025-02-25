using System.Collections;
using System.Collections.Generic;
using UnityEngine;

VariblesWork

using UnityEngine;

public class VariblesWork : MonoBehaviour
{
    // Declare variables of different types
    private int myInt = 42;
    private float myFloat = 3.14f;
    private char myChar = 'A';
    public string myName = "Your Name"; // Public variable that you can edit in the Inspector

    void Start()
    {
        // Print variables in Start() method
        Debug.Log("Integer value: " + myInt);
        Debug.Log("Float value: " + myFloat);
        Debug.Log("Character value: " + myChar);
    }

    void Update()
    {
        // Print your name in Update() method
        Debug.Log("My name is: " + myName);
    }
}
