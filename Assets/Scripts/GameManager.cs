using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        Dog dog = new Dog("Firulais");

        dog.Attack();
        Debug.Log(dog.CurrentHealth);
    }
}
