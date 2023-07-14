using UnityEngine;

public class CristalPicUpTextDestroy : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroyPicUpText", 1.2f);
    }

    void DestroyPicUpText()
    {
        Destroy(gameObject);
    }
}
