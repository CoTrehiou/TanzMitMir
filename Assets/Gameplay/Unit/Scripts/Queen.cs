using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : Unit
{

    [SerializeField] int numberEgg = 100;


    protected override void ChooseNextPosition()
    {
        Lay();
        base.ChooseNextPosition();
    }

    private void Lay()
    {
        if(numberEgg <= 0)
        {
            numberEgg--;
            GameManager.instance.SpawnEgg(_currentPosition, _team);
        }
    }
}
