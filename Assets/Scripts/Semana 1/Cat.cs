using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        SetStartingHealth(12);

        attackName = "Scratch!";
    }

    public override void Attack()
    {
        base.Attack();
        currentHealth -= 5;
        maxHealth += 5; 
    }
}
