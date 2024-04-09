using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator animator;
    bool IsRun;


    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector3 movement =
            new Vector3(horizontalInput, 0f, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);


        if (horizontalInput > 0)
        {

            transform.localScale = new Vector3(1, 1, 1);
            animator.SetBool("Run", true);
        }
        else if (horizontalInput < 0)
        {

            transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool("Run", true);
        }

        else
        {
            animator.SetBool("Run", false);
        }
        //else if(Mathf.Abs(horizontalInput)<1)
        //{
        //   animator.SetBool("Run",false);
        //}

        

    }
}
    

