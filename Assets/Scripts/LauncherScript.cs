using UnityEngine;

public class LauncherScript : MonoBehaviour
{

    [SerializeField]
    SpringJoint2D spring;

    [SerializeField]
    Rigidbody2D rigidBody;

    [SerializeField]
    KeyCode triggerKey;

    [SerializeField]
    float maxdistance;

    [SerializeField]
    float launchPower;

    [SerializeField]
    GameObject camera;

    [SerializeField]
    GameObject ball;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(triggerKey))
        {
            if (spring.distance > maxdistance)
            {
                spring.distance -= 0.01f;
            }
        }

        if (Input.GetKeyUp(triggerKey))
        {
            rigidBody.AddForce(transform.up * launchPower);
            spring.distance = 3.11f;
            ball.GetComponent<SoundScript>().PlayBurp();
            StartCoroutine(camera.GetComponent<CameraScript>().CameraShake(2, 0.3f));
        }
    }
    
    
}
