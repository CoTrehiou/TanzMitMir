using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    public Position _positionTile;
    public TileState _tileState;

    public enum TileState
    {
        Empty,
        Unit,
        Wall
    }

    public Tile(int positionX, int positionY)
    {
        _positionTile.X = positionX;
        _positionTile.Y = positionY;
        _tileState = TileState.Empty;
    }

    public TileState GetTile(Position position)
    {
        return Board.boardInstance._tabTiles[position.X, position.Y]._tileState;
    }

    public void SetStateTile(Position position, Tile.TileState state)
    {
        Board.boardInstance._tabTiles[position.X, position.Y]._tileState = state;
    }
}
