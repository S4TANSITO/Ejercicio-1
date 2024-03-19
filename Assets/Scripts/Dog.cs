using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        maxHealth = 10;
        currentHealth = maxHealth;

        attackName = "Bite!";
    }

    public override void Attack()
    {
        base.Attack();
        currentHealth += 10;
    }
}
