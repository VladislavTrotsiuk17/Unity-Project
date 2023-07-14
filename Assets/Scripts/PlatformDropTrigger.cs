using UnityEngine;

public class PlatformDropTrigger : MonoBehaviour
{

    [SerializeField] private Rigidbody prefabRigidbody;

    private void Start()
    {        
        prefabRigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {          
            Invoke("ChangePrefabRigidbodyToKinematic", 2f);
        }
    }

    private void ChangePrefabRigidbodyToKinematic()
    {
            prefabRigidbody.isKinematic = false;       
    }
}