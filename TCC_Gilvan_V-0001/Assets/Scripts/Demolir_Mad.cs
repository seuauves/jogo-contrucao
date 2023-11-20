using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demolir_Mad : MonoBehaviour
{
    //private GameObject visualObject;
    //private BoxCollider boxCollider;
    //private GameObject serraCostas;

    public GameObject objetoAtivado;
    public float distanciaMax = 3f;
    

    //void Start()
    //{
    //    visualObject = transform.GetChild(0).gameObject;
    //    boxCollider = GetComponent<BoxCollider>();
    //}   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoAtivado != null && objetoAtivado.activeSelf)
            {
                Collider[] colliders = Physics.OverlapSphere(transform.position, distanciaMax);
                foreach (Collider collider in colliders)
                {
                    if (collider.CompareTag("SegundoObjeto"))
                    {
                        Destroy(collider.gameObject);
                    }
                }
            }
        }
        //if (Input.GetKeyDown(KeyCode.E))
        //{
            // ativo ou inativo
            //if (visualObject != null)
            //{
                //visualObject.SetActive(false);
            //}
            //if (boxCollider != null)
            //{
            //    boxCollider.enabled = false;
            //}
        //}
    }

    //public void Destruir()
    //{
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //        // ativo ou inativo
    //        if (visualObject != null)
    //        {
    //            visualObject.SetActive(false);
    //        }
    //        if (boxCollider != null)
    //        {
    //            boxCollider.enabled = false;
    //        }
    //    }
    //}
}