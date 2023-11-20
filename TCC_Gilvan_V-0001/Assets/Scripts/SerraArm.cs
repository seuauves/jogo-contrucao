using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerraArm : MonoBehaviour
{   
    public GameObject serraCostas;
    // Metodo chamado quando ocorre colisao
    private void OnCollisionEnter(Collision collision)
    {
        // verifica se o objecto que colidiu tem a tag "Player".
      if (collision.gameObject.CompareTag("Player"))
      {
        // gameObject.SetActive(false);
        // destroi o objeto
        Destroy(gameObject);

        if (serraCostas != null)
        {
            serraCostas.SetActive(true);
        }
      }
    }
    
}
