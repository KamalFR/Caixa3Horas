using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextoDano : MonoBehaviour
{
    [SerializeField] private PersonagemManeger personagem;
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        text.SetText(personagem.dano.ToString());
    }
}
