using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class PlaceObjectOnPlane : MonoBehaviour
{
    //serialize field in brackets keeps an object private, but we can view it in the unity editor
    [SerializeField] GameObject placedPrefab;

    //we just want to spawn one object, we can use the var to make sure we don't respawn more than one
    GameObject spawnedObject;

    void OnPlaceObject(InputValue value)
    {
        //get the screen touch position
        Vector2 touchPosition = value.Get<Vector2>();

        //get the screen touch position
        //raycast from the touch position into the 3D scene
        //if the raycast hits a plane
            //get the hit point (pose) on the plane
            //if this is the first time placing an object,
                //instatiate the prefab at the hit position and rotation
            //otherwise
                //change the position of the previously placed object
    }

    //start is called before the first frame updates
    void Start()
    {
        
    }
}
