using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleController : MonoBehaviour
{
    private Animator animation;
    private Transform target;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float maxRange;
    [SerializeField]
    private float minRange;

    private void Start()
    {
        animation = GetComponent<Animator>();
        target = FindObjectOfType<PlayerController>().transform;
        
    }
    private void Update()
    {
        if (Vector3.Distance(target.position, transform.position) <= maxRange &&
           Vector3.Distance(target.position, transform.position) >= minRange)
        {
            FollowPlayer();
        }
        else if(Vector3.Distance(target.position,transform.position) >= maxRange)
        {
            //GoHome();
        }
    }
    public void FollowPlayer()
    {
        animation.SetBool("isMoving", true);
        animation.SetFloat("Horizontal", target.position.x-transform.position.x);
        animation.SetFloat("Vertical", target.position.y - transform.position.y);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Vector2 difference = transform.position - collision.transform.position;
            transform.position = new Vector2(transform.position.x + difference.x, transform.position.y + difference.y);
        }
    }
}
