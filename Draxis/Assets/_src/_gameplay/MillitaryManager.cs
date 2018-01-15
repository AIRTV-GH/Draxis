using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MillitaryManager : MonoBehaviour {

    public List<Troop> troops;

    public void Start()
    {
        troops = new List<Troop>();
    }

    public void addTroop(int type, int attackPower, int life, Vector2 pos)
    {
        troops.Add(new Troop(type, attackPower, life, pos));
    }

    public void deleteTroop(Troop troop)
    {
        troops.Remove(troop);
    }
}
