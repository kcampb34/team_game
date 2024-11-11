using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArcadeEndMenu : MonoBehaviour
{
    // References to the three square GameObjects
    public GameObject square1;
    public GameObject square2;

    // Variable to track the currently active square
    private int activeSquare = 1;

    // Start with one square active and the others inactive
    void Start()
    {
        SetActiveSquare(1); // Default to square 1
    }

    // Call this method to activate a specific square and deactivate the others
    public void SetActiveSquare(int squareNumber)
    {
        activeSquare = squareNumber;
        square1.SetActive(squareNumber == 1);
        square2.SetActive(squareNumber == 2);
    }

    // Example input handling
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SetActiveSquare(1); // Activate square 1
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            SetActiveSquare(2); // Activate square 2
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadNextScene();
        }
    }

    // Load the next scene based on the currently active square
    void LoadNextScene()
    {
        switch (activeSquare)
        {
            case 1:
                SceneManager.LoadScene("Tiny Red");
                break;
            case 2:
                SceneManager.LoadScene("Frog Manufacturing ComplexFacility");
                break;
            default:
                Debug.LogError("Invalid square selection!");
                break;
        }
    }
}
