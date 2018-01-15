
//*********************************************************
//
// author   : Ismail Ozsaygi
// $purpose : Display UI for troops on click.
// $attach  : Attach this to Troop game object.
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TroopUI : MonoBehaviour 
{

	private GameObject  ui_object;

    private void Start()
    {
        // Auto detect the ui object.
        ui_object     = GameObject.FindGameObjectWithTag( "Action - Troop" );
    }

    private void troopui_change_state()
    {
        UItils.ui_change_alpha( ui_object );
    }

    private void OnMouseUpAsButton()
    {
        troopui_change_state();
    }

}
