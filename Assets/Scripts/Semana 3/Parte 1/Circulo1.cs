using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo1 : Figura1, IObtenerArea
{
    private float _radio;

    public Circulo1(float _radio)
    {
        this._radio = _radio;
    }

    float IObtenerArea.Area()
    {
        float area = _radio * Mathf.Pow(3.14f, 2);

        return area;
    }
}
