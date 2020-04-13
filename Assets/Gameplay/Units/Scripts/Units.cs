using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Units : MonoBehaviour
{


    protected int _health = 100;
    protected int _damage = 50;

    public bool alive = true;

    protected Team _team;

    protected int _moveSpeed;


    public enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT,
    }

    public enum Team
    {
        RED,
        BLUE
    }

    protected Direction _optionsMovement;
    public Position _currentPosition;

    protected void SpiderInit(Position positionInitial, int health, int damage, Team team, int moveSpeed)
    {
        _currentPosition = positionInitial;
        _health = health;
        _damage = damage;
        _team = team;
        _moveSpeed = moveSpeed;
    }

    protected void ChooseNextPosition()
    {
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
                CheckPosition(_currentPosition.X, _currentPosition.Y + 1);
                break;
            case Direction.DOWN:
                CheckPosition(_currentPosition.X, _currentPosition.Y - 1);
                break;
            case Direction.LEFT:
                CheckPosition(_currentPosition.X - 1, _currentPosition.Y);
                break;
            case Direction.RIGHT:
                CheckPosition(_currentPosition.X + 1, _currentPosition.Y);
                break;
        }
    }

    private void CheckPosition(int x, int v)
    {
        throw new NotImplementedException();
    }
}


