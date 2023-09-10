using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //essas sao as variaveis
    public Animator playerAnim;
    public Rigidbody playerRigid;
    public float w_speed, wb_speed, olw_speed, rn_speed, ro_speed;
    public bool walking;
    public Transform playerTrans;


    // Aqui e a funcao void FixedUpdate(), Incluindo os codigos de movimento 
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            playerRigid.velocity = transform.forward * w_speed * Time.deltaTime;

        }
        if(Input.GetKey(KeyCode.S))
        {
            playerRigid.velocity = -transform.forward * wb_speed * Time.deltaTime;
        }

    }
    


    // Update e os codigos das animacoes
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.W))
        {
            //Quando o W for pressionado, a animacao 'walk' sera setada e o 'idle' sera resetado.
            playerAnim.SetTrigger("walk");
            playerAnim.ResetTrigger("idle");
            walking = true;
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            //Quando o W for pressionado, a animacao 'walk' sera setada e o 'idle' sera resetado.
            playerAnim.ResetTrigger("walk");
            playerAnim.SetTrigger("idle");
            walking = false;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            playerAnim.SetTrigger("walkback");
            playerAnim.ResetTrigger("idle");
        }
        if(Input.GetKey(KeyCode.A))
        {
            playerTrans.Rotate(0, -ro_speed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            playerTrans.Rotate(0, ro_speed * Time.deltaTime, 0);
        }
        if(walking == true)
        {
            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                //setps1.SetActive(false);
                //steps2.SetActive(true);
                w_speed = w_speed + rn_speed;
                playerAnim.SetTrigger("run");
                playerAnim.ResetTrigger("walk");
                
            }
            if(Input.GetKeyUp(KeyCode.LeftShift))
            {
                //steps1.SetActive(true);
                //setps2.SetActive(false);
                w_speed = olw_speed;
                playerAnim.ResetTrigger("run");
                playerAnim.SetTrigger("walk");
            }
        }












    }
}
