using UnityEngine;
using UnityEngine.SceneManagement;

public class UIRetry : MonoBehaviour
{
    public string sceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}