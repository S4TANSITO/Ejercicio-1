using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadrado : Figura
{
    private float _lado;

    public Cuadrado(float _lado)
    {
        this._lado = _lado;
    }

    public override float Area()
    {
        float area = _lado * _lado;

        return area;
    }
}
