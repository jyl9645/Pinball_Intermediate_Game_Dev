using UnityEngine;

public class BlockadeScript : MonoBehaviour
{

    [SerializeField]
    GameObject blockade;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball"))
        {
            blockade.SetActive(true);
        }
    }
}
