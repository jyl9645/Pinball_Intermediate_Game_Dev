using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    Transform ballTransform;

    [SerializeField]
    float smooth = 0.3f;

    Vector3 velocity = Vector3.zero;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = ballTransform.position;
        target.z = -10;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity, smooth);
    }
}
