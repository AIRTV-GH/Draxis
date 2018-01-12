
//*********************************************************
//
// author   : created by Cody Stough
// $purpose : Allow the player to control the games camera during play.
// $attach  : attached to the Main Camera.
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float zoomSpeed;    //Speed of zooming in/out
    public float scrollSpeed;  //Speed of WASD movement
    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        //WASD movement for PC
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * scrollSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * scrollSpeed;

        //Zoom controls for PC
        if (Input.GetAxis("Mouse ScrollWheel") > 0.0f) { //Zoom In
            cam.orthographicSize -= zoomSpeed * Time.deltaTime;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0.0f) { //Zoom Out
            cam.orthographicSize += zoomSpeed * Time.deltaTime;
        }

        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, 1.5f, 5.0f);

        transform.Translate(x, 0, z); //We need to translate the global instead of local position
    }
}
