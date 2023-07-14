using TMPro;
using UnityEngine;

public class UIGamePlayed : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gamePlayedScoreText;

    private int gamePlayedScore;

    void Start()
    {
        gamePlayedScore = PlayerPrefs.GetInt("gamePlayedScore");
        gamePlayedScoreText.text = "Games Played Score: " + gamePlayedScore.ToString();
    }
}
