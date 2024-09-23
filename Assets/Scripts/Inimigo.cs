using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : PersonagemManeger
{
    [SerializeField] private GameObject caixa;
    private float time;
    void Start()
    {
        inimigo = GameObject.FindGameObjectWithTag("Player").GetComponent<PersonagemManeger>();
        AumentarForca();
        time = 0f;
    }
    void Update()
    {
        if (LutaControle.turno == TurnoControle.TurnoInimigo)
        {
            time += Time.time;
            if(time > 1.5f)
            {
                AudioManager.instance.danoAudio.Play();

                Atacar();
                LutaControle.turno = TurnoControle.TurnoPlayer;
                time = 0f;
            }
        }
    }
    public override void Morrer()
    {
        GameObject set = Instantiate(caixa);
        inimigo.SetNewInimigo(set);
        Destroy(gameObject);
    }
    public void AumentarForca()
    {
        vida += (LutaControle.caixasDestruidas / 2) * vida;
        dano += (LutaControle.caixasDestruidas / 2) * dano;
    }
}
