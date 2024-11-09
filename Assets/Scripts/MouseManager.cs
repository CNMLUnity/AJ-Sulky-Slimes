using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    [Header("Mouse Info")]
    public Vector3 clickStartLocation;
    [Header("Physics")]
    public Vector3 launchVector;
    public float launchForce;

    [Header("Slime")]
    public Transform slimeTransform;
    public Rigidbody slimeRigidbody;

    [Header("Lives")]
    public LivesManager livesManager;

    private Vector3 ohyeah;

    public Vector3 cannonball;
    // Start is called before the first frame update
                                                
    // Update is called once per frame
    
    void Start(){
        cannonball = slimeTransform.position;
        Debug.Log("I COMMIT CRIMES USING DIRECTION AND MAGNITUDE OH YEAH");
        Debug.Log(cannonball);
    }
    
        void Update()
    {if (livesManager.lives < 0)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0)){

            clickStartLocation = Input.mousePosition;
        }

        if (Input.GetMouseButton(0)){

            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;
            launchVector = new Vector3(
                mouseDifference.x * 1f, 
                mouseDifference.y * 1.2f, 
                mouseDifference.y * 1.5f
            );
            slimeTransform.position = cannonball - launchVector / 400;
            launchVector.Normalize();
        }

        if (Input.GetMouseButtonUp(0)){

            slimeRigidbody.isKinematic = false;
            launchVector.y += 0.01f;
            slimeRigidbody.AddForce(launchVector * launchForce,ForceMode.Impulse);
            livesManager.RemoveLife();
        }
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0)){
            slimeTransform.position = cannonball;
            slimeRigidbody.isKinematic = true;

        }
    }

}
