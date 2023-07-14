using TMPro;
using UnityEngine;

public class UICristalScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cristalScoreText;

    private int cristalScore;
    void Start()
    {
        cristalScore = PlayerPrefs.GetInt("cristalScore");
        cristalScoreText.text = "Cristal Score: " + cristalScore.ToString();
    }


}
