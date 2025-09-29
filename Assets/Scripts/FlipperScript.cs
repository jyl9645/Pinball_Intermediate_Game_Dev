using UnityEngine;

public class FlipperScript : MonoBehaviour
{

    [SerializeField]
    KeyCode flipKey;

    [SerializeField]
    Rigidbody2D flipperbody;

    [SerializeField]
    float flipPower;
        

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(flipKey))
        {
            flipperbody.AddForce(transform.up * flipPower);
        }
    }
}
