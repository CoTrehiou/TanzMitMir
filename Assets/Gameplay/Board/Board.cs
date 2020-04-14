using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public  static Board boardInstance;
    [SerializeField] Transform _planeGround;
    [SerializeField] int width = 10;
    [SerializeField] int height = 10;

    public Tile[,] _tabTiles;

    void Awake()
    {
      
        boardInstance = this;
        _planeGround.localScale = new Vector3(width, 0, height);
        _tabTiles = new Tile[width,height];
        Debug.Log("Tableau initialisée avec " + width * height + " cases");
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                _tabTiles[i, j] = new Tile(i,j);
            }
        }
    }

    public void AssignUnitToTile(Unit unit, Position unitPosition)
    {
        _tabTiles[unitPosition.X, unitPosition.Y].AssignUnit(unit, unitPosition);
    }

    public void RemoveUnitToTile(Position unitPosition)
    {
        _tabTiles[unitPosition.X, unitPosition.Y].RemoveUnit();
    }
}




