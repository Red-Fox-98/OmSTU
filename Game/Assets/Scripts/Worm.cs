using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : Entity, IDamageable
{
    [SerializeField] private int lives = 1;

    public void ApplyDamage(int incomingDamage)
    {
        lives--;
        if (lives < 1)
        {
            Destroy(gameObject);
        }
    }
}