using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varibleswork : MonoBehaviour
{
    
    int num = 5;
    float fl = 2.1f;    
    char letter = 'A';
     string name = "Samir";
  
     // Start is called before the first frame update 
     void Start()
     {
         // Print variables: int, float, char in Start()
         print(num);
         print(fl);
         print(letter);
     }
     
     // Update is called once per frame 
     void update()
     {
         // define variable string as public and print your name in the Update()
         print (name);
     }
 }