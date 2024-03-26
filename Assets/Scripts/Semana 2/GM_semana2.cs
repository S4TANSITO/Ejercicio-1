using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM_semana2 : MonoBehaviour
{
    [HideInInspector] public Dictionary<string, Figura> FigurasDisponibles = new Dictionary<string, Figura>();

    private void Start()
    {
        Figura triangulo = new Triangulo(1, 2);
        Figura rectangulo = new Rectangulo(2, 6);
        Figura cuadrado = new Cuadrado(5);
        Figura circulo = new Circulo(3);

        FigurasDisponibles.Add("triangulo", triangulo);
        FigurasDisponibles.Add("rectangulo", rectangulo);
        FigurasDisponibles.Add("cuadrado", cuadrado);
        FigurasDisponibles.Add("circulo", circulo);
    }

    public void ImprimirArea(string figura)
    {
        Debug.Log(FigurasDisponibles[figura].Area());
    }
}
