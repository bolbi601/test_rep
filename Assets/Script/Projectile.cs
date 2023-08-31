using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public LayerMask whatIsSolid;

    public GameObject destroyEffect;
    public int damage;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null )
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                Debug.Log("Enemy damage");
                hitInfo.collider.GetComponent<Entity>().TakeDamage(damage);
            }
            DestroyProjectile();
        }



        transform.Translate(transform.up * speed * speed * Time.deltaTime); 
    }
    void DestroyProjectile()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
