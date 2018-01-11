
//*********************************************************
//
// $author  : Ismail Ozsaygi
// $purpose : Handling the multiple screen resolutions & setting resolution manually.
// $attach  : "Initialization.cs" will auto add this to "Application Manager" game object at "scene_intro"
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Keep window properties as one.
struct wnd_properties
{
    public int  wnd_width;
    public int  wnd_height;
    public bool wnd_isFullScreen;
}

class Display : MonoBehaviour 
{

    private wnd_properties new_window;

    //**********
    // Get the native resolution from system & apply it. (Auto resolution detection)
    //**********
	public void display_set_res()
    {
        // Get resolution here.
        new_window.wnd_width        = Screen.currentResolution.width;
        new_window.wnd_height       = Screen.currentResolution.height;
        new_window.wnd_isFullScreen = true;

        // Apply window properties.
        Screen.SetResolution( new_window.wnd_width , new_window.wnd_height , new_window.wnd_isFullScreen );

        // Saving the resolution to PlayerPrefs
		PrefUtils.pref_set_int( "wnd_width" , new_window.wnd_width );
		PrefUtils.pref_set_int( "wnd_height", new_window.wnd_height );

        // For testing (can be removed later)
        Debug.Log( "Width       : " + new_window.wnd_width.ToString() );
        Debug.Log( "Height      : " + new_window.wnd_height.ToString() );
        Debug.Log( "Full Screen : " + new_window.wnd_isFullScreen.ToString() );

        Debug.Log( "Width from PlayerPrefs  : " + PlayerPrefs.GetInt("wnd_width"));
        Debug.Log( "Height from PlayerPrefs : " + PlayerPrefs.GetInt("wnd_height"));
    }

    //**********
    // Just a overload function for resolution.
    // With this function we can set the resolution manually when we need it.
    //**********
    public void display_set_res( int p_width , int p_height , bool p_isFullScreen )
    {
        new_window.wnd_width        = p_width;
        new_window.wnd_height       = p_height;
        new_window.wnd_isFullScreen = p_isFullScreen;

        Screen.SetResolution( new_window.wnd_width , new_window.wnd_height , new_window.wnd_isFullScreen );
    }
}
