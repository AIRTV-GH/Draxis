using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MillitaryManager : MonoBehaviour {

    public List<Troop> troops;
    public GameObject[] troopModels;
    public GridManager GM;

    public void Start()
    {
        troops = new List<Troop>();
        troopModels = new GameObject[1];
        GM = transform.parent.GetComponent<GridManager>();
    }

    public void addTroop(int type, int attackPower, int life, Vector2 pos)
    {
        troops.Add(new Troop(type, attackPower, life, pos));
        GameObject newTroop = Instantiate(troopModels[0], new Vector3(pos.x, 0.75f, pos.y), Quaternion.identity);
        newTroop.transform.parent = gameObject.transform;
    }

    public void deleteTroop(Troop troop)
    {
        troops.Remove(troop);
    }

    public void addTroopButton()
    {
        addTroop(1, 1, 1, GM.selectedTile);
    }
}
