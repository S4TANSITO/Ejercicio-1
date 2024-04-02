using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo1 : Figura1
{
    private float _radio;

    public Circulo1(float _radio)
    {
        this._radio = _radio;
    }

    public override float Area()
    {
        float area = _radio * Mathf.Pow(3.14f, 2);

        return area;
    }
}
