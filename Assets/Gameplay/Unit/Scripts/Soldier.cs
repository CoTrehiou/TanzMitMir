using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : Unit
{
    public new void Init(int health, int damage, int moveSpeed,Team team)
    {
        base.Init(health, damage, moveSpeed, team);
        Debug.Log("Soldier ready");
    }
}
