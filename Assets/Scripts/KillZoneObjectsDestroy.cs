using UnityEngine;

public class KillZoneObjectsDestroy : MonoBehaviour
{
    [SerializeField] private GameObject lossScreens;
    [SerializeField] private GameObject gameScreens;

    private int gamePlayedScore;

    private void Start()
    {
        gamePlayedScore = PlayerPrefs.GetInt("gamePlayedScore");
    }
    private void OnTriggerEnter(Collider other)
    {       
        if (other.CompareTag("platforms"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("ball"))
        {
            gamePlayedScore++;
            PlayerPrefs.SetInt("gamePlayedScore", gamePlayedScore);
            AudioManager.instance.GameOverEffect();
            gameScreens.SetActive(false);
            lossScreens.SetActive(true);
            Destroy(other.gameObject);
        }

    }
}
