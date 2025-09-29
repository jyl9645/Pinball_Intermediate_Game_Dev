using Unity.Collections;
using UnityEngine;

public class LiverScript : MonoBehaviour
{

    float left_limit = -2.3f;

    float right_limit = 2.1f;

    float dir = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= right_limit)
        {
            dir *= -1;
        }

        if (transform.position.x <= left_limit)
        {
            dir *= -1;
        }

        transform.position += new Vector3(dir, 0, 0);
    }
}
