using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextoCaixasQuebradas : MonoBehaviour
{
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        text.SetText(LutaControle.caixasDestruidas.ToString());
    }
}
