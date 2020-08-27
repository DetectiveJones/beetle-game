using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScaler : MonoBehaviour
{
    public float startSize = 3f;
    public float minSize = 1f;
    public float maxSize = 6f;

    public float speed = 2.0f;

    private Vector3 targetScale;
    private Vector3 baseScale;
    private float currScale;

    void Start()
    {
        baseScale = transform.localScale;
        transform.localScale = baseScale * startSize;
        currScale = startSize;
        targetScale = baseScale * startSize;
    }

    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, speed * Time.deltaTime);

        // If you don't want an eased scaling, replace the above line with the following line
        //   and change speed to suit:
        //transform.localScale = Vector3.MoveTowards (transform.localScale, targetScale, speed * Time.deltaTime);

    }

    public void ChangeSize(bool bigger)
    {

        if (bigger)
            currScale++;
        else
            currScale--;

        currScale = Mathf.Clamp(currScale, minSize, maxSize + 1);

        targetScale = baseScale * currScale;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            //other.gameObject.SetActive(false);
            Debug.Log("Scale Changed");
            ChangeSize(true);
        }
    }
}
