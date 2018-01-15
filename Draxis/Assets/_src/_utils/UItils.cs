
//*********************************************************
//
// author   : Ismail Ozsaygi
// $purpose : Contains functions for UI utilities.
// $attach  : Do not need to attach just call the functions from different files.
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UItils : MonoBehaviour 
{

    //******
    // Changes the alpha of given UI game object.
    //******
	public static void ui_change_alpha( GameObject p_uiObj )
    {
        CanvasGroup cnv;
        cnv = p_uiObj.GetComponent< CanvasGroup >();
        if( cnv == null )
        {
            Debug.Log( "Given object has no canvas group component in it !" );
            return;
        }
        else
        {
            // If UI object is already visible   , make it invisible
            // If UI object is already invisible , make it visible
            if( cnv.alpha == 0 )
                cnv.alpha = 1;
            else
                cnv.alpha = 0;
        }
    }

}
