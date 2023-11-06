using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    private EnemyHealth enemyHealth;
    private BossHealth bossHealth;
    [SerializeField]
    private int damageToGive;
    [SerializeField] Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            //enemy
            enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            enemyHealth.HurtEnemy(damageToGive);
            rb.velocity = Vector2.zero;
            transform.SetParent(collision.transform);
            Destroy(gameObject, 0f);
        }
        if (collision.tag == "Boss")
        {
            //boss
            bossHealth = collision.gameObject.GetComponent<BossHealth>();
            bossHealth.HurtEnemy(damageToGive);
            rb.velocity = Vector2.zero;
            transform.SetParent(collision.transform);
            Destroy(gameObject, 0f);
        }
        if (collision.tag == "Wall")
        {
            this.GetComponent<Rigidbody2D>().isKinematic = true;
            rb.velocity = Vector2.zero;
            Destroy(gameObject, 0);
        }
    }
}
