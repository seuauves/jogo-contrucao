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
        // Ativar a anima��o quando necess�rio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("serra_animation");
        }
    }
}