using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] private AudioClip turnBallAudioClip;
    [SerializeField] private AudioClip pickupAudioClip;
    [SerializeField] private AudioClip gameOverAudioClip;

    private AudioSource audioSource;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();
    }

    public void PlayTurnBallEffect()
    {
        PlaySoundEffect(turnBallAudioClip);
    }

    public void PlayPickupEffect()
    {
        PlaySoundEffect(pickupAudioClip);
    }

    public void GameOverEffect()
    {
        PlaySoundEffect(gameOverAudioClip);
    }

    private void PlaySoundEffect(AudioClip soundEffect)
    {
        audioSource.PlayOneShot(soundEffect);
    }

}
