using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassarTurno : MonoBehaviour
{
    public void Passar_Turno()
    {
        LutaControle.turno = TurnoControle.TurnoInimigo;
        Player.attacked = false;
    } 
}
