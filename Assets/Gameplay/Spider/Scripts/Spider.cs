using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spider : MonoBehaviour
{


    protected int _health = 100;
    protected int _damage = 50;

    public bool alive = true;

    protected int _team;

    protected int _moveSpeed;

    public  struct OptionsMovement
    {
        public Position UP;
        public Position DOWN;
        public Position LEFT;
        public Position RIGHT;
    }
    public struct Position
    {
        public int X;
        public int Y;
    }
    protected OptionsMovement _optionsMovement;
    public Position _currentPosition;

    protected void SpiderInit(Position positionInitial, int health, int damage, int team, int moveSpeed)
    {
        _currentPosition = positionInitial;
        _health = health;
        _damage = damage;
        _team = team;
        _moveSpeed = moveSpeed;
    }

    protected void MoveNextPosition()
    {
        // Position nextPosition = new Position(Random.Range(_moveSpeed, - _moveSpeed), Random.Range(_moveSpeed, -_moveSpeed));
        int nextPosition = UnityEngine.Random.Range(0, 4);
        Debug.Log(nextPosition);
        switch (nextPosition)
        {
            case 0:
                Interact(_optionsMovement.UP);
                break;
            case 1:
                Interact(_optionsMovement.DOWN);
                break;
            case 2:
                Interact(_optionsMovement.LEFT);
                break;
            case 3:
                Interact(_optionsMovement.RIGHT);
                break;
            default:
                Debug.Log("Error return value");
                break;

        }

    }

    private void Interact(Position typePosition)
    {
        throw new NotImplementedException();
    }
}
