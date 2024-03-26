using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : Entidad
{
    public Jugador(int vida, int dmg) : base(vida, dmg) { }

    public override void RecibirDmg(int dmgRecibido)
    {
        base.RecibirDmg(dmgRecibido);
        if (EstaMuerto()) { GM_semana2_pt2.Instance.Derrota(); }
    }
}
