using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpaceInteractable : MonoBehaviour {

    public GridManager GM;
    public EmpireManager EPM;
    public CameraController CC;
    public Canvas gridSpaceUI;

    public void Start()
    {
        GM = GetComponentInParent<GridManager>();
        EPM = GameObject.Find("Empire Manager").GetComponent<EmpireManager>();
        CC = GameObject.Find("Main Camera").GetComponent<CameraController>();
        gridSpaceUI = GetComponentInChildren<Canvas>();
        gridSpaceUI.enabled = false;
    }

    public void OnMouseDown()
    {
        //Use this area to possible animate the ground when its tapped and held down.
    }

    public void OnMouseUpAsButton() //Only runs when the mouse up and mouse down locations are the same
    {
        GM.selectedTile = gameObject.transform.position; //Sets itself as the selected tile
        CC.centerCam(gameObject.transform.position); //Centers the Camera on itself
        gridSpaceUI.enabled = !gridSpaceUI.enabled; //Toggles the UI
        
    }
    public void Update() //This should not be the mobile solution, dont want 100 update calls per frame from the terrain.
    {
        if (GM.selectedTile != transform.position)
        {
            gridSpaceUI.enabled = false;
        }
    }
}
