using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Color teamRed = Color.red;
    public Color teamBlue = Color.blue;

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
}
