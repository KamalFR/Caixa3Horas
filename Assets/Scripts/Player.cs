using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : PersonagemManeger
{
    [HideInInspector] public static bool attacked;
    private Button button;
    void Start()
    {
        inimigo = GameObject.FindGameObjectWithTag("Inimigo").GetComponent<PersonagemManeger>();
        button = GetComponent<Button>();
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
                button.interactable = false;
            }
        }
    }
    public override void Morrer()
    {
        //cena de morte
    }
    private void Update()
    {
        if(attacked == false)
        {
            button.interactable = true;
        }
    }
}
