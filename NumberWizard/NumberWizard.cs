using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int lowest;

    int highest;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        lowest = 1;
        highest = 1000;
        guess = (lowest + highest) / 2;

        print("Welcome to Number Wizard!");
        print("Pick a number, dont tell me what it is...");
        print("The lowest number you can pick is: " + lowest);
        print("The highest number you can pick is: " + highest);
        print("Tell me if the number is higher or lower than " + guess);
        print("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            lowest = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            highest = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("You are correct, the number I was thinking is " + guess);
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (lowest + highest) / 2;
        print("Is it higher or lower than..." + guess);
    }
}
