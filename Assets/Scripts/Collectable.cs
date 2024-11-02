using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float distanceToMove;

    private Vector3 startingPosition;
    private Vector3 endingPosition;
    // Start is called before the first frame update
    void Start()
    {
         startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startingPosition + new Vector3(0.0f, Mathf.Sin(Time.time), 0.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Core"))
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.name == "Core")
        {
            gameObject.SetActive(false);
        }
    }
}
