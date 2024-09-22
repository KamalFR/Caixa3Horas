using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PersonagemManeger : MonoBehaviour
{
    [SerializeField] public int vida;
    [SerializeField] public int dano;
    protected PersonagemManeger inimigo;

    public void Atacar()
    {
        inimigo.ReceberDano(dano);
    }
    public abstract void Morrer();
    public void ReceberDano(int dano)
    {
        vida -= dano + Random.Range(0, dano);
        if (vida <= 0)
        {
            Morrer();
        }
    }
    public void SetNewInimigo(GameObject newInimigo)
    {
        inimigo = newInimigo.GetComponent<PersonagemManeger>();
    }
}
