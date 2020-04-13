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


    public struct Position
    {
        public int X;
        public int Y;
    }

    public enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT,
    }
    protected Direction _optionsMovement;
    public Position _currentPosition;

    protected void SpiderInit(Position positionInitial, int health, int damage, int team, int moveSpeed)
    {
        _currentPosition = positionInitial;
        _health = health;
        _damage = damage;
        _team = team;
        _moveSpeed = moveSpeed;
    }

    protected void ChooseNextPosition()
    {
        // Position nextPosition = new Position(Random.Range(_moveSpeed, - _moveSpeed), Random.Range(_moveSpeed, -_moveSpeed));
        int nextPosition = UnityEngine.Random.Range(0, 4);
        Debug.Log(nextPosition);
        switch (nextPosition)
        {
            case 0:
                Interact(Direction.UP);
                break;
            case 1:
                Interact(Direction.DOWN);
                break;
            case 2:
                Interact(Direction.LEFT);
                break;
            case 3:
                Interact(Direction.RIGHT);
                break;
            default:
                Debug.Log("Error return value");
                break;
        }
    }

    private void Interact(Direction direction)
    {
        switch (direction)
        {
            case Direction.UP:
                break;
            case Direction.DOWN:
                break;
            case Direction.LEFT:
                break;
            case Direction.RIGHT:
                break;
        }
            
    }
}

public struct Position
{
    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; }
    public int Y { get; }


    /*  public Position UP;
      public Position DOWN;
      public Position LEFT;
      public Position RIGHT;*/
}
