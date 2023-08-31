using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacle : Entity

{
    private SpriteRenderer sprite;
    public Animator anim;
   

    private void Awake()
    {

        sprite = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponentInChildren<Animator>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage();
            anim.SetTrigger("boom");
            Invoke("Des", 1f);



        }

    }

    
    private void Des()
    {
        Destroy(gameObject);
    }

    
}

