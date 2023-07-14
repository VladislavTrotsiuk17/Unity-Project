using UnityEngine;
using TMPro;

public class BallController : MonoBehaviour
{
    [SerializeField] private float forwardSpeed = 0;

    [SerializeField] private GameObject menuScreens;
    [SerializeField] private GameObject gameScreens;
    [SerializeField] private GameObject screenBlock;

    [SerializeField] private TextMeshProUGUI progressScoreTextInGame;
    [SerializeField] private TextMeshProUGUI progressScoreTextInEndGame;

    private int progressScoreCount;

    private bool isTurn;

    private void Update()
    {
        ShowProgressScore();

        if (PlayerPrefs.GetInt("cheatToggleState") == 0)
        {           
            transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
            screenBlock.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("cheatToggleState") == 1)
        {
            screenBlock.SetActive(true);
            
        }
    }

    public void IsPresedTurnButton()
    {
        progressScoreCount++;
        AudioManager.instance.PlayTurnBallEffect();

        if (isTurn)
        {
            transform.rotation = Quaternion.Euler(0f, 45f, 0f);
            isTurn = false;
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, -45f, 0f);
            isTurn = true;
        }
    }

    public void IsPresedStartButton()
    {
        forwardSpeed = 3;
        menuScreens.SetActive(false);
        gameScreens.SetActive(true);
    }

    private void ShowProgressScore()
    {
        progressScoreTextInGame.text = progressScoreCount.ToString();
        progressScoreTextInEndGame.text = progressScoreCount.ToString();
    }

}