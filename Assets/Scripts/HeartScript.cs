using System.Collections;
using UnityEngine;

public class HeartScript : MonoBehaviour
{

    public GameObject bloodPrefab;
    float beatTime = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Beat(beatTime));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ball"))
        {
            collision.gameObject.GetComponent<ManagerScript>().AddScore(30);
            beatTime -= 0.1f;
            GameObject blood = Instantiate(bloodPrefab);
            blood.transform.position = gameObject.transform.position;
        }

        
        
    }

    public IEnumerator Beat(float time)
    {
        yield return new WaitForSeconds(time);
        this.GetComponent<Animator>().SetTrigger("Beat");

    }

}
