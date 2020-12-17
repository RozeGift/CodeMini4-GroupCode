using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject playerMov;
    //Set xyz position of camera 
    Vector3 cameraoffset = new Vector3(0, 1, -4);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //camera will follow player
        transform.position = Vector3.Lerp(transform.position, playerMov.transform.position + cameraoffset, 0.1f);
    }
}
