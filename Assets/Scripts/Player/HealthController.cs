using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    public int maxHealth;
    [SerializeField]
    public int currenHealth;
    private bool flashActive;
    [SerializeField]
    private float flashLength;
    [SerializeField]
    private float flashCounter;
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if(flashActive)
        {
            if (flashCounter > flashLength * .99f)
            {
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0f);
            }
            else if (flashCounter > flashLength * .82f)
            {
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1f);
            }
            else if(flashCounter > flashCounter  * .66f)
            {
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0f);
            }
            else if (flashCounter > flashCounter * .49f)
            {
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1f);
            }
            else if (flashCounter > flashCounter * .33f)
            {
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0f);
            }
            else if (flashCounter > flashCounter * .16f)
            {
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1f);
            }
            else if (flashCounter > 0f)
            {
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0f);
            }
            else
            {
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1f);
                flashActive = false;
            }
            flashCounter -= Time.deltaTime;
        }
    }
    public void HurtPlayer(int damageToGive)
    {
        currenHealth -= damageToGive;
        flashActive = true;
        flashCounter = flashLength;
        if(currenHealth<=0)
        {
            gameObject.SetActive(false);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            UIManager.Instance.ActiveLosePanel(true);
        }
    }
    public void AddHealth(int _value)
    {
        currenHealth = Mathf.Clamp(currenHealth + _value, 0, maxHealth);
    }

}
