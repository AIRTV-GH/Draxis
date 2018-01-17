
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

    private IEnumerator Start()
    {
        new_display = GetComponent< Display >();
        new_display.display_set_res();
        yield return new WaitForSeconds( 4.0f );
        SceneUtils.change_scene_async( 1 );
    }

}
