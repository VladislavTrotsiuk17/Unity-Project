using UnityEngine;

public class UISetings : MonoBehaviour
{
    [SerializeField] private GameObject setings;
    [SerializeField] private GameObject menu;

    public void OpenSetings()
    {
        setings.SetActive(true);
        menu.SetActive(false);
    }

}
