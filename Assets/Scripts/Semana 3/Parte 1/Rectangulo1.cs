using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo1 : Figura1
{
    private float _base;
    private float _altura;

    public Rectangulo1(float _base, float _altura)
    {
        this._base = _base;
        this._altura = _altura;
    }

    public override float Area()
    {
        float area = _base * _altura;

        return area;
    }
}
