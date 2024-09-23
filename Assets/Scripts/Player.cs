using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : PersonagemManeger
{
    private bool attacked;
    void Start()
    {
        inimigo = GameObject.FindGameObjectWithTag("Inimigo").GetComponent<PersonagemManeger>();
        LutaControle.caixasDestruidas = 0;
        LutaControle.turno = TurnoControle.TurnoPlayer;
        attacked = false;
    }
    public void FazerAtaque()
    {
        if (attacked == false)
        {
            if (LutaControle.turno == TurnoControle.TurnoPlayer)
            {
                AudioManager.instance.atackAudio.Play();
                Atacar();
                attacked = true;
            }
        }
    }
    public override void Morrer()
    {
        //cena de morte
    }
}
