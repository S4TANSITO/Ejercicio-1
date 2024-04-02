using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMelee1 : Entidad1, IAtaque
{
    public EnemigoMelee1(int vida, int dmg) : base(vida, dmg) { }

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
}
