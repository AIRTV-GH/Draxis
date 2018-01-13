
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
    private CanvasGroup ui_obj_canvas;

    private void Start()
    {
        // Auto detect the ui object.
        ui_object     = GameObject.FindGameObjectWithTag( "Action" );
        ui_obj_canvas = ui_object.GetComponent< CanvasGroup >();
    }

    private void cityui_change_state()
    {
        // If ui is activated , disable it.
        // If ui is disabled  , activate it.
        // Just change the alpha value for object.
        if( ui_obj_canvas.alpha == 1 )
            ui_obj_canvas.alpha = 0;
        else
            ui_obj_canvas.alpha = 1;
    }

    private void OnMouseDown()
    {
        cityui_change_state();
    }

}
