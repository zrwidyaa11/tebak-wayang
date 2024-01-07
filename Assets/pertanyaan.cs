using System.Collections;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMechanic : MonoBehaviour
{
    public GameObject correctFeedback;
    public GameObject wrongFeedback;
    public TMP_InputField inputField;


    public void VerifyAnswer(string expectedAnswer)
    {
        string input = inputField.text.Trim();

        if (string.Equals(expectedAnswer, input, StringComparison.OrdinalIgnoreCase))
        {
            correctFeedback.SetActive(true);
            wrongFeedback.SetActive(false);
            Debug.Log("Correct! The answer matches: " + expectedAnswer);


        }
        else
        {
            wrongFeedback.SetActive(true);
            correctFeedback.SetActive(false);
            Debug.Log("Incorrect. The answer is: " + expectedAnswer);
        }
    }
}