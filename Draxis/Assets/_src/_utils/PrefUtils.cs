
//*********************************************************
//
// $purpose : Will set data to player prefs & will get data from player prefs.
// $note    : Functions a static so we can access them just like "PrefUtils.FunctionName"
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefUtils : MonoBehaviour 
{

	//*****
	// Save int to player prefs.
	//*****
	public static void pref_set_int( string key , int value )
	{
		PlayerPrefs.SetInt( key , value );
	}

	//*****
	// Get int from player prefs.
	//*****
	public static int pref_get_int( string key )
	{
		int result;
		result = PlayerPrefs.GetInt( key );
		return ( result );
	}
}
