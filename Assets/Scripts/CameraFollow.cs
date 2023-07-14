using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothSpeed = 3f;
    private Vector3 cameraOffset;
    private float minZ = -2.75f;

    private Vector3 cameraPosition;
    private Vector3 previousTargetPosition;

    private void Start()
    {
        cameraOffset = transform.position - target.position;
        previousTargetPosition = target.position;
    }

    private void LateUpdate()
    {
        if (target.position != previousTargetPosition)
        {
            cameraPosition = target.position + cameraOffset;
            cameraPosition.y = transform.position.y;
            cameraPosition.z = Mathf.Max(cameraPosition.z, minZ);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, cameraPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }

        previousTargetPosition = target.position;
    }
}