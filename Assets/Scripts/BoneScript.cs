using UnityEngine;

public class BoneScript : MonoBehaviour
{
    GameObject owner;
    [SerializeField]
    GameObject manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        owner = gameObject.transform.parent.gameObject;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ball"))
        {
            manager.GetComponent<ManagerScript>().AddScore(20);
            gameObject.transform.parent.GetComponent<Animator>().SetTrigger("Breakoff");

            Invoke("death", 1f);
        }

        
    }

    public void death()
    {
        owner.SetActive(false);
    }
}
