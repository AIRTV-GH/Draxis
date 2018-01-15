using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpaceInteractable : MonoBehaviour {

    public GridManager GM;

    public void Start()
    {
        GM = GetComponentInParent<GridManager>();
    }

    public void OnMouseDown()
    {
        Debug.Log(transform.position);
        GM.selectedTile = gameObject.transform.position;
    }
}
