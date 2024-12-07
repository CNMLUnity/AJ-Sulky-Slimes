using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishscript : MonoBehaviour
{
    public GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        //print(gameObject.GetComponent<Rigidbody>().isKinematic);

    }
    // Update is called once per frame
    void Update()
    {
        if (gameController.GetComponent<Jigsaw>().fishActivated) {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Core") {
            gameController.GetComponent<Jigsaw>().fishActivated = true;
            //print(gameController.GetComponent<Jigsaw>().fishActivated);
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
