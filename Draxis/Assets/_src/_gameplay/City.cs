
//*********************************************************
//
// $created by Cody Stough
// $purpose : Class to represent a city template
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour {

    public string       cityName;
    public Vector2      cityPosition;

    public City(string name, Vector2 position)
    {
        cityName = name;
        cityPosition = position;
    }
}
