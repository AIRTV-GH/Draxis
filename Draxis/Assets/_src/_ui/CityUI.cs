
//*****************************************************
// 
// created by Ismail Ozsaygi
// purpose : display a UI for actions when player clicks a city
// attach  : attach this to city game object that will be created.
//
//*****************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityUI : MonoBehaviour 
{

	private GameObject  ui_object;

    private void Start()
    {
        // Auto detect the ui object.
        ui_object     = GameObject.FindGameObjectWithTag( "Action" );
    }

    private void cityui_change_state()
    {
        UItils.ui_change_alpha( ui_object );
    }

    private void OnMouseDown()
    {
        cityui_change_state();
    }

}
