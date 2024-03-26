using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        SetStartingHealth(7);

        attackName = "Bite!";
    }

    public override void Attack()
    {
        base.Attack();
        currentHealth += 10;
    }
}
