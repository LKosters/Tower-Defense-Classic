using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 direction;
    [SerializeField] private int dmg = 2;

    // Set the direction for the projectile to move
    public void SetDirection(Vector2 dir)
    {
        direction = dir;
    }

    private void Update()
    {
        // Move the projectile in the specified direction
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(dmg);
        Debug.Log("collision");
        Destroy(gameObject);
    }
}
