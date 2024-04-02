using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_semana3 : MonoBehaviour
{
    [HideInInspector] public Dictionary<string, Figura1> FigurasDisponibles = new Dictionary<string, Figura1>();

    private void Start()
    {
        Figura1 triangulo = new Triangulo1(1, 2);
        Figura1 rectangulo = new Rectangulo1(2, 6);
        Figura1 cuadrado = new Cuadrado1(5);
        Figura1 circulo = new Circulo1(3);

        FigurasDisponibles.Add("triangulo", triangulo);
        FigurasDisponibles.Add("rectangulo", rectangulo);
        FigurasDisponibles.Add("cuadrado", cuadrado);
        FigurasDisponibles.Add("circulo", circulo);
    }

    public void ImprimirArea(string figura)
    {
        IObtenerArea figuraConArea = (IObtenerArea)FigurasDisponibles[figura];

        // Llamar al método Area() a través de la interfaz IObtenerArea
        float area = figuraConArea.Area();

        Debug.Log($"El área de la figura {figura} es: {area}");
    }
}
