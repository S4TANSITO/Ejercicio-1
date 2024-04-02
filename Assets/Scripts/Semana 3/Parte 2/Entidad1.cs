using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entidad1
{
    protected int vida;
    protected int dmg;
    public int Dmg { get => dmg; }
    public int Vida { get => vida; }

    public Entidad1(int vida, int dmg)
    {
        this.vida = vida;
        this.dmg = dmg;
    }

    public virtual void Atacar(Entidad1 entAtacada)
    {
        if (EstaMuerto())
        {
            //GM_semana2_pt2.Instance.SiguienteTurno();
            return;
        }

        if (entAtacada.EstaMuerto()) { return; }
        entAtacada.RecibirDmg(dmg);
    }

    public virtual void RecibirDmg(int dmgRecibido)
    {
        vida -= dmgRecibido;
        if (EstaMuerto()) { vida = 0; }
    }

    public virtual bool EstaMuerto()
    {
        return vida <= 0 ? true : false;
    }
}
