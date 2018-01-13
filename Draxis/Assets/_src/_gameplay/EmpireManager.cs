
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
    public List<City> cities; //List of cities in our empire. Can be used to prevent overlapping cities, min distance between, displaying a list of all cities, etc.
    public GameObject city;
    public float cityDensity;

    public void Start()
    {
        cities = new List<City>();
    }

    public bool cityDensityCheck(Vector2 cityPos)
    {
        bool pass = false;
        if (cities.Count > 0)
        {
            foreach (City c in cities)
            {
                if (Vector2.Distance(cityPos, c.cityPosition) < cityDensity)
                {
                    pass = false;
                    break;
                }
                else
                {
                    pass = true;
                }
            }
        }
        else
        {
            pass = true;
        }

        return pass;
    }

    public void addCity(Vector2 cityPos, string cityName) //gets called when a city is created
    {
        if (cityDensityCheck(cityPos))
        {
            cities.Add(new City(cityName, cityPos)); //Adds a new City object to the List: cities.
            GameObject newCity = Instantiate(city, new Vector3(cityPos.x, 0.75f, cityPos.y), Quaternion.identity); //Instantiates the city model
            newCity.transform.parent = gameObject.transform;
            //Used for testing purposes
            Debug.Log("City Name: " + cityName + " City Position: " + cityPos);
        }
    }
}
