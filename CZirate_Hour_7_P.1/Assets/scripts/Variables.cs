using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int damage = 30; //positive or negative whole numbers
        float speed = 10.0f; //decimal values, must be terminated with f
        double rocketSpeed = 1004.4234243; //similar to float, but hold larger value
        bool gameOver = false; //true or false
        char someCharacter = 'Á'; //single character enclosed in single quotes
        string manyCharacters = "The night is dark and full of terrors";
        //multiple characters enclosed in double quotes

        Debug.Log("damage value is " + damage);
        Debug.Log("speed: " + speed);
        Debug.Log("rocketSpeed" +  rocketSpeed);
        Debug.Log("is the game over? " + gameOver);
        Debug.Log("someCharacter: " + someCharacter);
        Debug.Log("manyCharacters: " + manyCharacters);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
