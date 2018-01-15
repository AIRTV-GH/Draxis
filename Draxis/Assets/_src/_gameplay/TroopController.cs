
//*********************************************************
//
// author   : Ismail Ozsaygi
// $purpose : Allows the player controls troop and move them.
// $attach  : Attach it to player's troops simply.
//
//*********************************************************


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopController : MonoBehaviour 
{

    public Camera maincam; // Assign from inspector.
    public bool   isTroopSelected = false;

    private void Update()
    {
        tc_movement();
    }

    //********
    // For this function please check : https://answers.unity.com/questions/376735/get-world-coordinates-from-mouse-click.html
    //********
    private void tc_movement()
    {
        float distance = 4.0f;
        // Move the troops if player pressed the right click & troop is selected.
        if( Input.GetMouseButtonDown( 1 ) && isTroopSelected )
        {
            // Create our raycast to detect mouse hit position.
            Ray ray                            = maincam.ScreenPointToRay( Input.mousePosition );
            Vector3 point                      = ray.origin + ( ray.direction * distance );
            Debug.Log( "Clicked Point : " + point.ToString() );
            this.gameObject.transform.position = point;
            // We are done with movement so lets finish movement.
            isTroopSelected                    = false;
        }
    }

    private void OnMouseEnter()
    {
        transform.localScale = new Vector3( 0.6f , 0.6f , 0.6f ); // Just a simple selection animation.
    }

    private void OnMouseExit()
    {
        transform.localScale = new Vector3( 0.5f , 0.5f , 0.5f );
    }

}
