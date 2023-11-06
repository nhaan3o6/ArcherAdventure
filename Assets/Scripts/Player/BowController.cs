using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowController : MonoBehaviour
{
    //[SerializeField]
    //private Rigidbody2D rb;
    //[SerializeField]
    //private Camera cam;

    //Vector2 mousePos;
    //private void Update()
    //{
    //    mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    //}
    //private void FixedUpdate()
    //{
    //    Vector2 lookDir = mousePos - rb.position;
    //    float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 0f;
    //    rb.rotation = angle;
    //}
    public float rotationSpeed = 10f;
    private Vector3 mousePosition;
    private void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;
        Vector3 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
