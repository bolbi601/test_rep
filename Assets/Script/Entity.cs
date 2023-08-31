using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public int health;
    public GameObject deathEffect;
    public Animator anim;
    private void Awake()
    {
        
        anim = GetComponentInChildren<Animator>();
        
    }

        public void TakeDamage(int damage)
    {
        health -= damage;
    }
    public virtual void GetDamage()
        {

        }

        public virtual void Die()
        {
            Destroy(this.gameObject);
        }
    private void Update()
    {
        if (health <= 0)
        {
            Instantiate(deathEffect, transform.position,    Quaternion.identity);

            anim.SetTrigger("boom");
             Invoke("Des", 1f);

        }
    }
    private void Des()
    {
        Destroy(gameObject);
    }
}
