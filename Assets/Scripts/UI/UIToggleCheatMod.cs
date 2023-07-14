using UnityEngine;
using UnityEngine.UI;

public class UIToggleCheatMod : MonoBehaviour
{
    [SerializeField] private Toggle toggle;

    private void Update()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("cheatToggleState", 1);
        }
        else
        {
            PlayerPrefs.SetInt("cheatToggleState", 0);
        }
    }
}
