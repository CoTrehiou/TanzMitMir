using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    [SerializeField] Transform _planeGround;
    [SerializeField] int width = 10;
    [SerializeField] int height = 10;




    void Awake()
    {
        _planeGround.localScale = new Vector3(width,0, height);
    }

    /*
    TileState Tile(Position position) {
        if()
    }
    */
}

public class Tile{
    public Position _positionTile;
    public TileState _tileState;

    public void InitTile(int positionX, int positionY)
    {
        _positionTile.X = positionX;
        _positionTile.Y = positionY;
    }
    public enum TileState
    {
        Empty,
        Unit,
        Wall
    }

    TileState GetTile(Position position)
    {
        return _tileState;
    }
}


