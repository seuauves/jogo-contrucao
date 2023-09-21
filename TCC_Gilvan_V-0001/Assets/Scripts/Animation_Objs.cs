using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Objs : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // ativar a animacao quando preciso
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("serra_animation");
        }
    }
}