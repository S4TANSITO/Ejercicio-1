using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoRango1 : Entidad1, IAtaque
{
    private int balas;

    public EnemigoRango1(int vida, int dmg, int balas) : base(vida, dmg)
    {
        this.balas = balas;
    }

    public void Atacar(Entidad1 entAtacada)
    {
        if (EstaMuerto())
        {
            //GM_semana2_pt2.Instance.SiguienteTurno();
            Debug.Log("Estoy muerto :c");
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
