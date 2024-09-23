using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caixa : PersonagemManeger
{
    private AudioSource enemyAudio;

    [SerializeField] private GameObject gatoCaixa;
    [SerializeField] private GameObject goblim;
    [SerializeField] private GameObject dragon;
    [SerializeField] private GameObject aumentoDano;
    [SerializeField] private GameObject aumentoVida;
    private GameObject selected;
    private int aux;
    private float time;
    void Start()
    {
        aux = Random.Range(0, 4);
        if(aux == 0)
        {
            selected = aumentoVida;
        }
        if (aux == 1)
        {
            selected = aumentoDano;
        }
        if (aux >= 2)
        {
            SelectInimigo();
        }
        inimigo = GameObject.FindGameObjectWithTag("Player").GetComponent<PersonagemManeger>();
        time = 0f;
    }
    void Update()
    {
        if(LutaControle.turno == TurnoControle.TurnoInimigo)
        {
            time += Time.time;
            if (time > 1.5f)
            {
                LutaControle.turno = TurnoControle.TurnoPlayer;
                time = 0f;
            }
        }
    }
    public override void Morrer()
    {
        if (aux >= 2)
        {
            enemyAudio.Play();
        }

        LutaControle.turno = TurnoControle.TurnoPlayer;
        Player.attacked = false;
        GameObject set = Instantiate(selected, transform.position, transform.rotation);
        inimigo.SetNewInimigo(set);
        Destroy(gameObject);
        LutaControle.caixasDestruidas++;
    }
    public void SelectInimigo()
    {
        int aux2 = Random.Range(0, 3);
        if( aux2 == 0)
        {
            selected = gatoCaixa;
            enemyAudio = AudioManager.instance.caixinhaAudio;
        }
        if(aux2 == 1)
        {
            enemyAudio = AudioManager.instance.goblinAudio;
            selected = goblim;
        }
        if(aux2 >= 2)
        {
            enemyAudio = AudioManager.instance.dragonAudio;
            selected = dragon;
        }
    }
}
