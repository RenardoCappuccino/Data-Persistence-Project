using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text highScoreText;

    private const string HighScoreKey = "HighScore";

    void Start()
    {
        // Display the current high score when the game starts
        UpdateHighScoreUI();
    }

    public void UpdateHighScore(int score, string playerName)
    {
        // Get the current high score
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);

        // If the current score is higher, update the high score
        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, score);
            PlayerPrefs.SetString("HighScorePlayer", playerName);
            UpdateHighScoreUI();
        }
    }

    void UpdateHighScoreUI()
    {
        // Display the current high score on the UI
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);
        string highScorePlayer = PlayerPrefs.GetString("HighScorePlayer", "Unknown");
        highScoreText.text = $"High Score: {currentHighScore} by {highScorePlayer}";
    }
}
