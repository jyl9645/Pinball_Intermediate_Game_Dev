using UnityEngine;

public class BloodScript : MonoBehaviour
{

    private Vector3 target;

    [SerializeField]
    float smooth;
    [SerializeField]
    GameObject manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = new Vector3(Random.Range(-4.76f, 6f), Random.Range(-5f, 13.51f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, target, smooth);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball"))
        {
            manager.GetComponent<ManagerScript>().AddScore(10);
            Destroy(gameObject);
        }
    }
}
