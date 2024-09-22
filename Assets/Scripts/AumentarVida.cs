using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarVida : PersonagemManeger
{
    [SerializeField] int aumentoVida;
    [SerializeField] private GameObject caixa;
    private float time;
    void Start()
    {
        time = 0f;
        inimigo = GameObject.FindGameObjectWithTag("Player").GetComponent<PersonagemManeger>();
    }
    void Update()
    {
        if (LutaControle.turno == TurnoControle.TurnoInimigo)
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
        inimigo.vida += aumentoVida;
        GameObject set = Instantiate(caixa);
        inimigo.SetNewInimigo(set);
        Destroy(gameObject);
    }
}
