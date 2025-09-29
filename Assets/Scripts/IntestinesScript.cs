using System.Collections;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class IntestinesScript : MonoBehaviour
{

    [SerializeField]
    float pushPower;

    [SerializeField]
    GameObject otherEntrance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator Teleport(float wait, Collider2D subject)
    {

        void resetEntrance()
        {
            otherEntrance.SetActive(true);
        }

        yield return new WaitForSeconds(wait);

        otherEntrance.SetActive(false);

        subject.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        subject.transform.position = otherEntrance.transform.position;
        subject.GetComponent<Rigidbody2D>().AddForce(transform.up * -1 * pushPower);

        subject.GetComponent<SpriteRenderer>().enabled = true;

        StopAllCoroutines();

        Invoke("resetEntrance", 2f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball"))
        {
            collision.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(Teleport(1.5f, collision));
        }
    }
}
