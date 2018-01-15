
//*********************************************************
//
// $created by Cody Stough
// $purpose : Class to represent a troop template
//
//*********************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Troop {

    public int type;
    public int attackPower;
    public int life;
    public Vector2 pos;

    public Troop(int Type, int AttackPower, int Life, Vector2 Pos)
    {
        type = Type;
        attackPower = AttackPower;
        life = Life;
        pos = Pos;
    }
}
