using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "WinCon")
        {
            SceneManager.LoadScene(1);
        }

        if (collision.gameObject.tag == "WinCo")
        {
            SceneManager.LoadScene(2);
        }
    }
}
