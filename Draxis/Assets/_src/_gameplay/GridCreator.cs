
//*********************************************************
//
// $created by Ismail Ozsaygi
// $purpose : creates grids right next to each other.
// $attach  : attach this to every grid game object.
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCreator : MonoBehaviour 
{
	public GameObject   gc_gridToCreate;

	private const float DISTANCE = 1.0f;

	private void Start()
	{
		gc_createGrid();
	}

	//*****
	// Creates grid with random direction.
	//*****
	private void gc_createGrid()
	{
		// Create grid if we are not created a grid before.
		// Create grid if there is a still space to create grids.
		if( GridManager.CURRENT_GRID_COUNT <= GridManager.MAX_GRIDS_ALLOWED )
		{
			int random = Random.Range( 1 , 4 );

			if( random == 1 )        // Upper direction
				Instantiate( gc_gridToCreate , new Vector3( this.gameObject.transform.position.x , this.gameObject.transform.position.y , this.gameObject.transform.position.z + DISTANCE ) , Quaternion.identity );
			else if( random == 2 )   // Down direction
				Instantiate( gc_gridToCreate , new Vector3( this.gameObject.transform.position.x , this.gameObject.transform.position.y , this.gameObject.transform.position.z + DISTANCE ) , Quaternion.identity );
			else if( random == 3 )   // Left direction
				Instantiate( gc_gridToCreate , new Vector2( this.gameObject.transform.position.x - DISTANCE , this.gameObject.transform.position.y ) , Quaternion.identity );
			else if( random == 4 )   // Right direction
				Instantiate( gc_gridToCreate , new Vector2( this.gameObject.transform.position.x + DISTANCE , this.gameObject.transform.position.y + DISTANCE ) , Quaternion.identity );

			// When we are creating grids in scene there will be alot of game objects.
			// It can be confusing so lets create grids as a child of "Grid Handler" game object.
			gc_gridToCreate.transform.parent = GameObject.FindGameObjectWithTag( "Grid Handler" ).transform;
		}
		else
		{
			Debug.Log( "Can not create more grids , maximum grids are created !" );
			return;
		}

		GridManager.CURRENT_GRID_COUNT++;
	}
}
