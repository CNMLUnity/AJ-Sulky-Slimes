using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
{
    public int lives;
    public GameObject[] hearts;
    //Scene scene = SceneManager.GetActiveScene();
    
    // Start is called before the first frame update

    public void RemoveLife()
    {
        lives -= 1;
        print("YOU LOST A LIFE, WHAT THE SIGMA" + lives);
        if (lives >= 0)
        {
            hearts[lives].SetActive(false);
        }
        if(lives <= 0)
        {
            if (SceneManager.GetActiveScene().name == "SulkySlimes" || SceneManager.GetActiveScene().name == "SulkySlimes 2")
            {
                SceneManager.LoadScene(3);
            }


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
