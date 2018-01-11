
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
    public GameObject groundGrid;
	private const float DISTANCE = 1.0f;  // How far will be the next grid ?

	private void Start()
	{
		gc_create();
	}

	//*****
	// Creates grid at the near of this game object.
	//*****
	private void gc_create()
	{
        for (int i = 0; i < 10; i++)
        {
            // Random value to choose grid's direction.
            int random = Random.Range(1, 4);

            if (random == 1)      // Up
                Instantiate(groundGrid, new Vector3(this.transform.position.x + DISTANCE, 0.0f, this.transform.position.z), this.gameObject.transform.rotation);
            else if (random == 2) // Down
                Instantiate(groundGrid, new Vector3(this.transform.position.x - DISTANCE, 0.0f, this.transform.position.z), Quaternion.identity);
            else if (random == 3) // Left
                Instantiate(groundGrid, new Vector3(this.transform.position.x, 0.0f, this.transform.position.z + DISTANCE), Quaternion.identity);
            else if (random == 4) // Right
                Instantiate(groundGrid, new Vector3(this.transform.position.x, 0.0f, this.transform.position.z - DISTANCE), Quaternion.identity);

            //GridManager.lastGridPos = new Vector2(); //the position of the most recently instantiated grid object.
        }
	}
}
