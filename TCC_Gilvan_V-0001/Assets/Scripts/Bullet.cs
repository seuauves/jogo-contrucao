using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameControll controll;

    public int danage = 25;

    private void OnTriggerEnter(Collider obj)
    {
        if(obj.CompareTag("Player"))
        {
            Debug.Log("DANO OBTIDO FEB");
            controll.DecrementLife(danage);
            //health -= 25;
            //Destroy(gameObject);
        }

        //Destroy(gameObject, 10f);
    }


}
