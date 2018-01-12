
//*********************************************************
//
// author   : created by Cody Stough
// $purpose : Allow the player to control the games camera during play(PC).
// $attach  : attached to the Main Camera.
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float zoomSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //WASD movement for PC controls
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        //PC zoom controls
        if (Input.GetAxis("Mouse ScrollWheel") > 0.0f)
        {
            Camera.main.orthographicSize -= zoomSpeed * Time.deltaTime;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0.0f)
        {
            Camera.main.orthographicSize += zoomSpeed * Time.deltaTime;
        }

        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, 1.5f, 5.0f); // Clamping the size value to prevent zooming too far in or out.

        transform.Translate(x, 0, z);
        
    }
}
