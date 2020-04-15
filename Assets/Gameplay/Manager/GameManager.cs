using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public Color colorTeamRed = Color.red;
    public Color colorTeamBlue = Color.blue;

    [Header("Queen")]
    [SerializeField] GameObject _queen;
    [SerializeField] int _queenHealth = 500;
    [SerializeField] int _queenDamage = 100;
    [SerializeField] int _queenMoveSpeed = 2;


    [Header("Queen positions")]
    [SerializeField] Transform _positionQueenRed;
    [SerializeField] Transform _positionQueenBlue;


    [Header("Soldier")]
    [SerializeField] GameObject _soldier;
    [SerializeField] int  _soldierHealth = 100;
    [SerializeField] int _soldierDamage  = 50;
    [SerializeField] int _soldierMoveSpeed = 1;

    [Header("Egg")]
    [SerializeField] GameObject _egg;

    List<Unit> _listUnit = new List<Unit>();

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SpawnQueen(_positionQueenRed, Unit.Team.RED);
        SpawnQueen(_positionQueenBlue, Unit.Team.BLUE);
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }

    public void SpawnEgg(Position _currentPosition, Unit.Team _team)
    {
        Vector3 positionEgg = new Vector3(_currentPosition.X, 0, _currentPosition.Y);
        GameObject o = Instantiate(_egg, positionEgg, Quaternion.identity);

        o.GetComponent<Egg>().eggTeam = _team;
        o.GetComponent<Egg>().Renderer();
    }

    internal void SpawnSoldier(Vector3 position, Unit.Team eggTeam)
    {
        GameObject o = Instantiate(_soldier, position, Quaternion.identity);
        o.GetComponent<Soldier>().Init(_soldierHealth, _soldierDamage, _soldierMoveSpeed, eggTeam);
    }

    private void SpawnQueen(Transform _positionQueen, Unit.Team team)
    {
        GameObject o = Instantiate(_queen, _positionQueenRed.position, Quaternion.identity);
        o.GetComponent<Queen>().Init(_queenHealth, _queenDamage, _queenMoveSpeed, team) ;
    }
}
