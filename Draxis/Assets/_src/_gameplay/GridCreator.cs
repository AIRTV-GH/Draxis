
//*********************************************************
//
// $created by Ismail Ozsaygi
// $purpose : creates grids right next to each other.
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCreator : MonoBehaviour 
{

	private const float DISTANCE = 10.0f;  // How far will be the next grid ?

	private void Start()
	{
		gc_create();
	}

	//*****
	// Creates grid at the near of this game object.
	//*****
	private void gc_create()
	{
		// Random value to choose grid's direction.
		int random = Random.Range( 1 , 4 );

		if( GridManager.GRIDS_CREATED < 10 )
		{
			if( random == 1 )      // Up
				Instantiate( this.gameObject , new Vector2( this.transform.position.x + DISTANCE , this.transform.position.y + DISTANCE ) , this.gameObject.transform.rotation );
			else if( random == 2 ) // Down
				Instantiate( this.gameObject , new Vector2( this.transform.position.x + DISTANCE , this.transform.position.y - DISTANCE ) , Quaternion.identity );
			else if( random == 3 ) // Left
				Instantiate( this.gameObject , new Vector2( this.transform.position.x + DISTANCE , this.transform.position.x - DISTANCE ) , Quaternion.identity );
			else if( random == 4 ) // Right
				Instantiate( this.gameObject , new Vector2( this.transform.position.x + DISTANCE , this.transform.position.x + DISTANCE ) , Quaternion.identity );
		}
		else
		{
			Debug.Log( "Can not create more grids , maximum grids created !" );
			return;
		}

		GridManager.GRIDS_CREATED++;
	}
}
