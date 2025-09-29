using System.Collections;
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

    public IEnumerator CameraShake(float dur, float power)
    {
        float passedTime = 0f;

        while (passedTime < dur)
        {
            float y_offset = Random.Range(-0.1f, 0.1f) * power;

            transform.localPosition += new Vector3(0, y_offset, 0);

            passedTime += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = new Vector3(0, 0, -10);
        //while (transform.localPosition != Vector3.zero)
        //{
        //transform.localPosition = Vector3.Lerp(transform.localPosition, Vector3.zero, 2);
        //}

        StopCoroutine("CameraShake");
    }
}
