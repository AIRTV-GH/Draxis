
//*********************************************************
//
// author   : Ismail Ozsaygi
// $purpose : Enables the troops to move.
// $attach  : Attach it to the troop movement button and call the function from its click event.
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopMoveButton : MonoBehaviour 
{

	public void tmb_enable_movement( GameObject troop )
    {
        TroopController tc = troop.GetComponent< TroopController >();
        tc.isTroopSelected = true;
        Debug.Log( "You are controlling a troop !" );
    }

}
