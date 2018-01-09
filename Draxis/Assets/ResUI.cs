
//**********************************************************************************
//
// $author  : Ismail Ozsaygi (ewo)
// $this file created for testing purpose
// $purpose : displays the native resolution as text in the screen.
//
//**********************************************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                                          // We are going to work with UI elements so lets add it.

// Attach this script to the any text object in scene.(UI)
public class ResUI : MonoBehaviour 
{

	private Text resTexT;

    private void Start()
    {
        resTexT = GetComponent< Text >();
    }

    

}
