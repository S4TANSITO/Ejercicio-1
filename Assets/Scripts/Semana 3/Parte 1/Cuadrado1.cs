using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadrado1 : Figura1
{
    private float _lado;

    public Cuadrado1(float _lado)
    {
        this._lado = _lado;
    }

    public override float Area()
    {
        float area = _lado * _lado;

        return area;
    }
}
