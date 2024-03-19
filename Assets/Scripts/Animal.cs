using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    private string name;
    protected int maxHealth;
    protected string attackName;
    protected int currentHealth;
    public int CurrentHealth { get => currentHealth; }

    public Animal(string name)
    {
        this.name = name;
    }

    public virtual void Attack() { Debug.Log($"{name} used {attackName}"); }
}
