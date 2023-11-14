using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer_Character : MonoBehaviour
{
    private Animator animator;

    public string parametroDaAnimacao = "Cube.001|Cube.001Action";

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        if (animator != null && !string.IsNullOrEmpty(parametroDaAnimacao))
        {
            animator.SetTrigger(parametroDaAnimacao);
            
        }

        else
        {
            Debug.LogWarning("Animator ou parametro da animacao nao configurados corretamente.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
