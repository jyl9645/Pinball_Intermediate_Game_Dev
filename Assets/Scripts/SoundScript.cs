using UnityEngine;
using UnityEngine.InputSystem.XR;

public class SoundScript : MonoBehaviour
{

    public AudioSource audioSource;

    public AudioClip burp;

    public AudioClip bone_crack;

    public AudioClip heart_hit;

    public AudioClip blood_splat;

    public AudioClip bounce;

    public AudioClip borderBounce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayBurp()
    {
        audioSource.PlayOneShot(burp);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("heart"))
        {
            audioSource.PlayOneShot(heart_hit);
        }

        if (collision.collider.CompareTag("bone"))
        {
            audioSource.PlayOneShot(bone_crack);
        }

        if (collision.collider.CompareTag("bounce"))
        {
            audioSource.PlayOneShot(bounce);
        }

        if (collision.collider.CompareTag("blood"))
        {
            audioSource.PlayOneShot(blood_splat);
        }
        
        if (collision.collider.CompareTag("border"))
        {
            audioSource.PlayOneShot(borderBounce);
        }
    }
}
