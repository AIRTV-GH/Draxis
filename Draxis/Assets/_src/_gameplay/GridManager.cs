
//*********************************************************
//
// $created by Ismail Ozsaygi
// $purpose : keeps track of how much grid is created in scene.
// $attach  : there is no need to attach this file to the any game object.since we are using static variables.
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour 
{
	public static readonly int MAX_GRIDS_ALLOWED = 10;       // How much grids can we create ? 
	public static int          CURRENT_GRID_COUNT = 0;        // How much grid created ?
}
