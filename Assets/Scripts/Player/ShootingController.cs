using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private GameObject arrowPrefab;
    [SerializeField]
    private float arrowForce;

    [SerializeField]
    private Transform skillPoint;
    [SerializeField]
    private GameObject firePrefab;
    [SerializeField]
    private float fireForce;

    [SerializeField]
    private float SkillCoolDown;
    private float nextSkill;

    [SerializeField]
    private float ShootCoolDown;
    private float nextArrow;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            SKill();
        }
    }
    public void Shoot()
    {
        if(Time.time > nextArrow)
        {
            nextArrow = Time.time + ShootCoolDown;
            GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.right * arrowForce, ForceMode2D.Impulse);
        }
    }    

    public void SKill()
    {
        if (Time.time > nextSkill)
        {
            nextSkill = Time.time + SkillCoolDown;
            GameObject fire = Instantiate(firePrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = fire.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.right * fireForce, ForceMode2D.Impulse);
        }

    }
}
