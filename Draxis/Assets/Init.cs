
//**********************************************************************************
//
// $author  : Ismail Ozsaygi (ewo)
// $this file created for testing purpose
// $purpose : calls the functions from display class the set resolution.Just drag this to any empty game object in scene.
//
//**********************************************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Whenever you drag this script to the game object it will auto add Display script to it.
// Bcoz it is required component.
[ RequireComponent( typeof( Display ) ) ] 
public class Init : MonoBehaviour 
{

    private Display dp_Instance;

    private void Start()
    {
        dp_Instance = GetComponent< Display >();              // Access our display script.
        dp_Instance.display_getNativeRes();                   // Get the native resolution & also set it.
    }

}
