using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GridSpaceInteractable : MonoBehaviour {

    public GridManager GM;
    public EmpireManager EPM;
    public MillitaryManager MM;
    public CameraController CC;


    public void Start()
    {
        GM = GetComponentInParent<GridManager>();
        EPM = GameObject.Find("Empire Manager").GetComponent<EmpireManager>();
        MM = GameObject.Find("Empire Manager").GetComponent<MillitaryManager>();
        CC = GameObject.Find("Main Camera").GetComponent<CameraController>();

    }

    public void OnMouseDown()
    {
        //Use this area to possible animate the ground when its tapped and held down.
    }

    public void OnMouseUpAsButton() //Only runs when the mouse up and mouse down locations are the same
    {
        if(!EventSystem.current.IsPointerOverGameObject()) { //Ignores click when mouse is over UI element
            GM.selectedTile = gameObject.transform.position; //Sets itself as the selected tile
            CC.centerCam(gameObject.transform.position); //Centers the Camera on itself
        }
    }
}
