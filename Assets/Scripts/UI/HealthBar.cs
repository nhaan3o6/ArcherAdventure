using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private HealthController healthPlayer;

    [SerializeField]
    public Slider healthBar;
    [SerializeField]
    public Text HPText;
    void Start()
    {
        healthPlayer = FindObjectOfType<HealthController>();
    }
    void Update()
    {
        healthBar.maxValue = healthPlayer.maxHealth;
        healthBar.value = healthPlayer.currenHealth;
        HPText.text = healthPlayer.currenHealth + "/" + healthPlayer.maxHealth;
    }
}
