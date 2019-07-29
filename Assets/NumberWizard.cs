using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    void StartGame () {
        guess = 500;
        max = 1001;
        min = 1;

        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number between 1 and 1000!");
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Your number was: " + guess + "!");
            StartGame();
        }
    }

    void NextGuess() {
        guess = (max+min)/2;
        Debug.Log("Is your number higher or lower than " + guess);
    }
}
