using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GridSpaceTemplate {
    
    public int gridSpaceType; //defines the type of grid space
    public int resource; //defines the resource on this grid space
    public Vector2 gridSpacePos; //defines the location of the grid space

    public GridSpaceTemplate(int type, int res, Vector2 pos)
    {
        gridSpaceType = type;
        resource = res;
        gridSpacePos = pos;
    }
}
