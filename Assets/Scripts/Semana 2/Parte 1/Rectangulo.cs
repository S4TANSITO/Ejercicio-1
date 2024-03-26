using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : Figura
{
    private float _base;
    private float _altura;

    public Rectangulo(float _base, float _altura)
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
