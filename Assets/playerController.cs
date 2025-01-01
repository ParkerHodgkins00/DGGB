using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Vector2 targetPos;
    public float movementSpeed;
    void Start()
    {
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");


        if (targetPos == (Vector2)transform.position)
        {
            if (h != 0)
            {
                targetPos.Set(targetPos.x += h , targetPos.y);
            }

            else if (v != 0)
            {
                targetPos.Set(targetPos.x, targetPos.y += v);
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, movementSpeed * Time.deltaTime);
    }
}
