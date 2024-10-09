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

    private Vector3 ohyeah;
    // Start is called before the first frame update
                                                
    // Update is called once per frame
    
    void Start(){
        ohyeah = slimeRigidbody.isKinematic;
    }
    
        void Update()
    {
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
            launchVector.Normalize();
        }

        if (Input.GetMouseButtonUp(0)){

            slimeRigidbody.isKinematic = false;
            slimeRigidbody.AddForce(launchVector * launchForce,ForceMode.Impulse);
        }
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0)){
            isKinematic = false;

        }
    }
}