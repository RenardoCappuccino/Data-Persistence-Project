using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class StartMenu : MonoBehaviour
{
    public TMP_InputField nameInputField;

    public void StartGame()
    {
        string playerName = nameInputField.text;
        PlayerPrefs.SetString("PlayerName", playerName); // Save player name
        SceneManager.LoadScene("main"); // Load main game scene
    }

    public void ResetGameData()
    {
        PlayerPrefs.DeleteAll(); // Delete all saved data
        Debug.Log("Game data reset !");
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit the game
        Debug.Log("Game quit !");
    }
}
