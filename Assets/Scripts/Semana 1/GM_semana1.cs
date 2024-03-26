using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_semana1 : MonoBehaviour
{
    private void Start()
    {
        Dog dog = new Dog("Firulais");

        dog.Attack();
        Debug.Log(dog.CurrentHealth);
    }
}
