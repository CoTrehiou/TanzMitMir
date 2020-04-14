using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    protected int _health = 100;
    protected int _damage = 50;
    protected bool alive = true;
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

    protected Unit(Position positionInitial, int health, int damage, Team team, int moveSpeed)
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

    protected void Interact(Direction direction)
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

    protected void CheckPosition(int x, int y)
    {
        switch (Board.boardInstance._tabTiles[x, y]._tileState)
        {
            case Tile.TileState.Empty:
                Move(x, y);
                break;
            case Tile.TileState.Unit:
                Attack(x,y);
                break;
            case Tile.TileState.Wall:
                break;
            default:
                break;
        }
    }

    protected void Move(int x, int y)
    {
        Position newPosition = new Position(x, y);
        transform.Translate(new Vector3(x, y));
        Board.boardInstance._tabTiles[x, y].SetStateTile(newPosition, Tile.TileState.Unit);
        Board.boardInstance._tabTiles[_currentPosition.X, _currentPosition.Y].SetStateTile(new Position(_currentPosition.X, _currentPosition.Y), Tile.TileState.Empty);
        
        Board.boardInstance.RemoveUnitToTile(_currentPosition);
        _currentPosition = newPosition;
        Board.boardInstance.AssignUnitToTile(this, _currentPosition);
    }
    protected virtual void Attack(int x, int y)
    {
        Tile tileEnnemy = Board.boardInstance._tabTiles[_currentPosition.X, _currentPosition.Y];
        if (tileEnnemy._unitAssigned._team != this._team)
        {
            tileEnnemy._unitAssigned.Damaged(_damage);
        }
    }

    protected void Damaged(int damage)
    {
        _health -= damage;
        if(_health <= 0)
        {
            Die();
        }
    }

    protected void Die()
    {
        gameObject.SetActive(false);
        Board.boardInstance.RemoveUnitToTile(_currentPosition);
    }
}


