using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    [SerializeField] float delayEclosion;
    [SerializeField] AudioSource _soundEclosion;

    [SerializeField] MeshRenderer _meshRendererEgg;

     public Unit.Team eggTeam;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(delayEclosion);
       // _soundEclosion.Play();
       // yield return new WaitUntil(() => !_soundEclosion.isPlaying);
        GameManager.instance.SpawnSoldier(transform.position, eggTeam);
        Destroy(this);
    }

    internal void Renderer()
    {
        switch (eggTeam)
        {
            case Unit.Team.RED:
                _meshRendererEgg.material.color = GameManager.instance.colorTeamRed;
                break;
            case Unit.Team.BLUE:
                _meshRendererEgg.material.color = GameManager.instance.colorTeamBlue;
                break;
            default:
                break;
        }
    }
}
