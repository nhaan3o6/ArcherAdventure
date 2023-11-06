using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    public int maxHealth;
    [SerializeField]
    public int currenHealth;

    public void HurtEnemy(int damageToGive)
    {
        currenHealth -= damageToGive;
        if (currenHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
