using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanel : MonoBehaviour
{
    [SerializeField]
    private Image imageShooting;
    [SerializeField]
    private float shootingCoolDown;
    bool isShootingCoolDown = false;

    [SerializeField]
    private Image imageSkilling;
    [SerializeField]
    private float skillingCoolDown;
    bool isSkillingCoolDown = false;



    private void Start()
    {
        imageShooting.fillAmount = 0;
        imageSkilling.fillAmount = 0;

        
    }
    private void Update()
    {
        Shooting();
        Skilling();

    }
    private void Shooting()
    {
        if (Input.GetButtonDown("Fire1") && isShootingCoolDown == false)
        {
            isShootingCoolDown = true;
            imageShooting.fillAmount = 1;
        }
        if (isShootingCoolDown)
        {
            imageShooting.fillAmount -= 1 / shootingCoolDown * Time.deltaTime;
            if (imageShooting.fillAmount <= 0)
            {
                imageShooting.fillAmount = 0;
                isShootingCoolDown = false;
            }
        }
    }
    private void Skilling()
    {
        if (Input.GetButtonDown("Fire2") && isSkillingCoolDown == false)
        {
            isSkillingCoolDown = true;
            imageSkilling.fillAmount = 1;
        }
        if (isSkillingCoolDown)
        {
            imageSkilling.fillAmount -= 1 / skillingCoolDown * Time.deltaTime;
            if (imageSkilling.fillAmount <= 0)
            {
                imageShooting.fillAmount = 0;
                isSkillingCoolDown = false;
            }
        }
    }
}