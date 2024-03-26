using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoRango : Entidad
{
    private int balas;

    public EnemigoRango(int vida, int dmg, int balas) : base(vida, dmg)
    {
        this.balas = balas;
    }

    public override void Atacar(Entidad entAtacada)
    {
        if (EstaMuerto())
        {
            GM_semana2_pt2.Instance.SiguienteTurno();
            return;
        }

        if (entAtacada.EstaMuerto()) { return; }

        if (balas <= 0)
        {
            Debug.Log("Sin balas uwu");
            return;
        }

        balas--;

        entAtacada.RecibirDmg(dmg);
    }
}
