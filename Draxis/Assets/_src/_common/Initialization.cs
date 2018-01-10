
//*********************************************************
//
// $author  : Ismail Ozsaygi
// $purpose : Loads the application settings at "scene_intro"
// $attach  : Will be attached to "Application Manager" game object at "scene_intro"
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ RequireComponent( typeof( Display ) ) ]
public class Initialization : MonoBehaviour 
{

	private Display new_display;

    private void Start()
    {
        new_display = GetComponent< Display >();
        new_display.display_set_res();
    }

}
