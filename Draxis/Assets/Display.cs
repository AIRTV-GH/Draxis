
//**********************************************************************************
//
// $author : Ismail Ozsaygi (ewo)
// $this file created for testing purpose
// $can be optimized later
// $note   : we can add a utilities scripts to get current window resolution later but it is not needed for now.
//
//**********************************************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I think it is better to save window properties under a struct.
// We could save them under Display class but i think it is not that much readable.
// Refresh rate (Hz) can be added later on.
struct wnd_properties
{
    public int  wnd_width;
    public int  wnd_height;
    public bool wnd_isFullScreen;
}

public class Display : MonoBehaviour 
{

	private wnd_properties new_screen;                                             // Instance of our struct.

    //************
    // Gets the native resolution.(I think this will also work for mobiles)
    // For this function , please take a look at : https://answers.unity.com/questions/16216/how-to-get-native-screen-resolution.html
    // Unity forum is a key place for us to achieve things.
    //************
    public void display_getNativeRes()
    {
        new_screen.wnd_width        = Screen.currentResolution.width;             // Get the width from native resolution.
        new_screen.wnd_height       = Screen.currentResolution.height;            // Get the height from native resolution.
        new_screen.wnd_isFullScreen = true;                                       // Game is 100% going to be full screen. (Mmm , i think ? :D)
        // We get all the properties we need , so lets apply them.
        display_setRes( new_screen.wnd_width , new_screen.wnd_height , new_screen.wnd_isFullScreen );
    }

    private void display_setRes( int p_width , int p_height , bool p_isFullScreen )
    {
        // Apply our resolution to screen.
        // $note : there is a overload parameter for this function.
        // it can take one more argument called "refreshRate" that is why i told we can add refresh rate in the beginning of this file.
        Screen.SetResolution( p_width , p_height , p_isFullScreen );
        // For testing lets print message to console (This can be removed later)
        Debug.Log( "Width  : " + p_width.ToString() );
        Debug.Log( "Height : " + p_height.ToString() );
    }

}
