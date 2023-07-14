using UnityEngine;

public class UIMenu : MonoBehaviour
{
    [SerializeField] private GameObject setings;
    [SerializeField] private GameObject menu;

    public void OpenMenu()
    {
        setings.SetActive(false);
        menu.SetActive(true);
    }
}
