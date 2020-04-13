using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spider : MonoBehaviour
{


    protected int _health;
    protected int _damage = 50;

    protected bool alive = true;

    protected int team;

    protected struct position
    {
        int X;
        int Y;
    }


    protected void SpiderInit()
    {

    }


}
