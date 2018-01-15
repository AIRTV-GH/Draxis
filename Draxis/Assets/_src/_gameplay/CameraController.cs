
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
    public float zoomLerpSpeed; //Speed of the zoom lerp
    public float scrollSpeed;  //Speed of WASD movement
    public Camera cam;
    public float zoomMax, zoomMin;

    float targetCamSize = 3.0f;

    // Update is called once per frame
    void Update()
    {
        #if UNITY_STANDALONE_WIN
        camera_pc_controls();
        #endif
    }

    private void camera_pc_controls()
    {
        //WASD movement for PC
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * scrollSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * scrollSpeed;
        transform.Translate(x, 0, z); //We need to translate the global instead of local position

        //Zoom controls for PC
        if (Input.GetAxis("Mouse ScrollWheel") > 0.0f) { //Zoom In
            targetCamSize -= zoomSpeed * Time.deltaTime;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0.0f){ //Zoom Out
            targetCamSize += zoomSpeed * Time.deltaTime;
        }
        targetCamSize = Mathf.Clamp(targetCamSize, zoomMax, zoomMin);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetCamSize, Time.deltaTime * zoomLerpSpeed);
    }
}
