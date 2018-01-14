
//*********************************************************
//
// $created by Cody Stough
// $purpose : Provide more flexible terrain generation options
// $attach  : attached to the grid handler
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCreaterV2 : MonoBehaviour {

    public Vector2 gridSize; //Vector2 that specifies length and width of the world

    public GameObject[] gridSpaces; //Game Object array of the different types of gridSpaces that can be spawned

    public GridManager GM;

    public void Start()
    {
        GM = GetComponent<GridManager>();
        if (GM == null)
        {
            Debug.Log("Unable to locate Grid Manager");
        }
    }

    public void gc_createWater() //Creates different forms of water areas in the world
    {

    }

    public void gc_createMountains() //Creates different forms of mountain area in the world
    {

    }

    public void gc_createGround() //Creates the initial ground in the world
    {
        for(int i = 0; i < gridSize.x; i++)
        {
            for(int j = 0; j < gridSize.y; j++)
            {
                GameObject newGridSpace = Instantiate(gridSpaces[0], new Vector3(i, 0.0f, j), Quaternion.identity);
                newGridSpace.transform.parent = gameObject.transform;
                GM.world.Add(new GridSpaceTemplate(1, 0, new Vector2(i, j)));
            }
        }
    }

    public void gc_populateResources() //Populates the world with resources
    {

    }
}
