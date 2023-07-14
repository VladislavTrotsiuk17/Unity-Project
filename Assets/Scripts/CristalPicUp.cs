using UnityEngine;

public class CristalPicUp : MonoBehaviour
{
    [SerializeField] private GameObject cristalPicUpTextPrefab;

    private int cristalScore;

    private void Start()
    {
        cristalScore = PlayerPrefs.GetInt("cristalScore");
    }
    private void OnTriggerEnter(Collider other)
    {       
        if (other.CompareTag("cristal"))
        {
            cristalScore++;
            AudioManager.instance.PlayPickupEffect();
            PlayerPrefs.SetInt("cristalScore", cristalScore);
            Instantiate(cristalPicUpTextPrefab, new Vector3(transform.position.x, 1.8f, transform.position.z), transform.rotation);
            Destroy(other.gameObject);                        
            
        }       
    }
 
}
