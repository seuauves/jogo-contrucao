using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColli : MonoBehaviour
{

    public Animator doorAnim;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnim.SetTrigger("open");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnim.SetTrigger("close");
        }
    }

}
