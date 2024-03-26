using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo : Figura
{
    private float _radio;

    public Circulo(float _radio)
    {
        this._radio = _radio;
    }

    public override float Area()
    {
        float area = _radio * Mathf.Pow(3.14f, 2);

        return area;
    }
}
