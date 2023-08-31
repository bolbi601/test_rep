using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Star : Entity
{
    [SerializeField] private int lives = 3;

    private void OnColisionEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage();
            lives--;
            Debug.Log("у червяка" + lives);
        }

        if (lives < 1)
            Die();
    }

    
}
