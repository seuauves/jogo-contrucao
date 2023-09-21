using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demolir_Mad : MonoBehaviour
{
    private GameObject visualObject;
    private BoxCollider boxCollider;


    void Start()
    {
        visualObject = transform.GetChild(0).gameObject;
        boxCollider = GetComponent<BoxCollider>();
    }   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // ativo ou inativo
            if (visualObject != null)
            {
                visualObject.SetActive(false);
            }
            if (boxCollider != null)
            {
                boxCollider.enabled = false;
            }
        }
    }
}