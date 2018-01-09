
// created for testing
// this code can be optimized later.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour 
{

    // Will be assigned from unity inspector.
	public GameObject[] actions;

    public void c_changeState()
    {
        // Simply we are getting the size of our game object array and looping the array.
        // We are activating every single object in this array.
        if( !actions[ 0 ].activeSelf )
        {
            // Activate all the actions if first one is disabled.
            int i;
            for( i = 0 ; i < actions.Length ; i++ )
                actions[ i ].SetActive( true );
        }
        else
        {
            // Hide all the actions if first one is enabled.
            int j;
            for( j = 0 ; j < actions.Length ; j++ )
                actions[ j ].SetActive( false );
        }
       
    }

    private void OnMouseDown()
    {
        c_changeState();
    }

}
