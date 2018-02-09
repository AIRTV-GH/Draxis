
//*********************************************************
//
// $author  : Ismail Ozsaygi
// $purpose : Toggles the fps display state.
// $attach  : Attach to Fps button under user interface.
//
//*********************************************************

using UnityEngine;

public class FpsButton : MonoBehaviour 
{
    // Call from button's click event.
    public void ToggleState()
    {
        if( Fps.IsEnabled )
            Fps.IsEnabled = false;
        else
            Fps.IsEnabled = true;
    }
}
