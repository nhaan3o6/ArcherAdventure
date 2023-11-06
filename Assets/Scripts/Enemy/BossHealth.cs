using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    [SerializeField]
    public int maxHealth;
    [SerializeField]
    public int currenHealth;

    [SerializeField] 
    private Animator anim;

    public void HurtEnemy(int damageToGive)
    {
        currenHealth -= damageToGive;
        if (currenHealth <= 0)
        {
            anim.SetTrigger("die");
            gameObject.SetActive(false);
            if (UIManager.HasInstance)
            {
                Time.timeScale = 0f;
                UIManager.Instance.ActiveVictoryPanel(true);
            }
        }
    }
}
