using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
{
    public int lives;
    public GameObject[] hearts;
    // Start is called before the first frame update

    public void RemoveLife()
    {
        lives -= 1;
        print("YOU LOST A LIFE, WHAT THE SIGMA" + lives);
        hearts[lives].SetActive(false);
        if(lives == 0)
        {
           SceneManager.LoadScene(0);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
