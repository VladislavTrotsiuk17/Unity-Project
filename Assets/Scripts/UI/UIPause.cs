using UnityEngine;

public class UIPause : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    
    private bool isPaused = false;

    public void Pause()
    {   
        if (!isPaused)
        {            
            Time.timeScale = 0f;
            pausePanel.SetActive(true);
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1f;
            pausePanel.SetActive(false);
            isPaused = false;
        }
    }
}
