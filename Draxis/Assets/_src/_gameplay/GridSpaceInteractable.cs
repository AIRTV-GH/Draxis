using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpaceInteractable : MonoBehaviour {

    public GridManager GM;
    public EmpireManager EPM;

    public void Start()
    {
        GM = GetComponentInParent<GridManager>();
        EPM = GameObject.Find("Empire Manager").GetComponent<EmpireManager>();
    }

    public void OnMouseDown()
    {
        //Use this area to possible animate the ground when its tapped and held down.
    }

    public void OnMouseUpAsButton() //Only runs when the mouse up and mouse down locations are the same
    {
        GM.selectedTile = gameObject.transform.position;

        //Activate a UI script for selecting a grid space
        //For now just instantly add a city
        //Vector2 cityPos = new Vector2(this.transform.position.x, this.transform.position.z);
        //EPM.addCity(cityPos, "New City"); //For now lets just instantly add a city
    }
}
