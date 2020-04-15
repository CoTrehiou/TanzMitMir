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
    [SerializeField] int _damageQueen = 100;


    [Header("Soldier")]
    [SerializeField] GameObject _soldier;
    [SerializeField] int  _soldierHealth = 100;
    [SerializeField] int _soldierDamage  = 50;
    [SerializeField] int _soldierMoveSpeed = 1;

    [Header("Egg")]
    [SerializeField] GameObject _egg;





    //public readonly List<Unit> unitsList = new List<Unit>();

    void Awake()
    {
        instance = this;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
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
        o.GetComponent<Soldier>().Init(_soldierHealth, _soldierHealth, _soldierMoveSpeed, eggTeam);
    }
}
