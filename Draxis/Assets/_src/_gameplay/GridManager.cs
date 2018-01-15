
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
	public static readonly int MAX_GRIDS_ALLOWED = 15;        // How much grids can we create ? 
	public static int          CURRENT_GRID_COUNT = 0;        // How much grid created ?
    public List<GridSpaceTemplate> world; //This is a list of every grid space in the world
    public Vector3 selectedTile; //This gets set whenever a grid space is clicked/tapped

    public void Start()
    {
        world = new List<GridSpaceTemplate>();
    }
}
