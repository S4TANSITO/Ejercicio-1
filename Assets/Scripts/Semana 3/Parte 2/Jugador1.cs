using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador1 : Entidad1, IAtaque
{
    public Jugador1(int vida, int dmg) : base(vida, dmg) { }

    public void Atacar(Entidad1 entAtacada)
    {
        if (EstaMuerto())
        {
            Debug.Log("Estoy muerto :c");
            return;
        }

        if (entAtacada.EstaMuerto()) { return; }
        entAtacada.RecibirDmg(dmg);
    }

    public override void RecibirDmg(int dmgRecibido)
    {
        base.RecibirDmg(dmgRecibido);
        if (EstaMuerto()) { GM_semana3_pt2.Instance.Derrota(); }
    }
}
