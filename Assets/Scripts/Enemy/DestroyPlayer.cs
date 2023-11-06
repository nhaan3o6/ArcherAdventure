using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPlayer : MonoBehaviour
{
    [SerializeField]
    private float waitToHurt;
    [SerializeField]
    private bool isTouching;
    private HealthController healthPlayer;
    [SerializeField]
    private int damageToGive;
    private void Start()
    {
        healthPlayer = FindObjectOfType<HealthController>();
    }
    private void Update()
    {
        if(isTouching)
        {
            waitToHurt -= Time.deltaTime;
            if(waitToHurt<=0)
            {
                healthPlayer.HurtPlayer(damageToGive);
                waitToHurt = 1f;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            //other.gameObject.SetActive(false);
            other.gameObject.GetComponent<HealthController>().HurtPlayer(damageToGive);
            //reloading = true;
        }
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            isTouching = true;
        } 
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            isTouching = false;
        }
    }
}
