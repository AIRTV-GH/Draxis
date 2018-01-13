
//*********************************************************
//
// $created by Cody Stough
// $purpose : (Currently) Manage the List of all cities in a particular empire, (Future) Manage alot more data about particular empires.
// $attach  : attach this to the Empire Manager Object
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpireManager : MonoBehaviour {

    [SerializeField]
    List<City> cities = new List<City>(); //List of cities in our empire. Can be used to prevent overlapping cities, min distance between, displaying a list of all cities, etc.

    public void addCity(Vector2 cityPos, string cityName) //gets called when a city is created
    {
        cities.Add(new City(cityName, cityPos)); //Adds a new City object to the List: cities.

        //Used for testing purposes
        Debug.Log("City Name: " + cityName + " City Position: " + cityPos);
    }
}
