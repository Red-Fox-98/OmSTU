using System;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingMonster : Entity, IDamageable
{
    private float speed = 3.5f;
    public Vector3 dir;
    private SpriteRenderer sprite;
    private int lives = 2;
    private float timer = 0f;
    public float cloningTimer = 5;
    public int maxClonesAllowed = 3;

    private void Start()
    {
        if (dir.sqrMagnitude < 0.01)
        {
            dir = transform.right;
        }
    }

    private void Update()
    {
        Move();
        timer += Time.deltaTime;
        if (timer > cloningTimer && maxClonesAllowed > 0)
        {
            Clone();
            timer = 0;
        }
    }

    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.1f + transform.right * dir.x * 0.7f, -0.1f);

        if (colliders.Length > 0) dir *= -1f;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, Time.deltaTime);
    }

    public void ApplyDamage(int incomingDamage)
    {
        lives--;
        if (lives < 1)
        {
            Destroy(gameObject);
        }
    }

    private void Clone()
    {
        GameObject clone = Instantiate(gameObject, transform.position + new Vector3(0, 1, 0), transform.rotation);
        WalkingMonster monster = clone.GetComponent<WalkingMonster>();
        monster.maxClonesAllowed-=1;
        monster.dir *= -1f;
        maxClonesAllowed--;
    }
}