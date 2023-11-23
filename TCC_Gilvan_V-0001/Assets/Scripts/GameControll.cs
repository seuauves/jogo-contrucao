using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControll : MonoBehaviour
{
    [SerializeField] private string Winner;
    public Animator playerAnim;
    public Player player;
    public int playerLife = 100;
    public GameObject Winne;

    public void DecrementLife(int dano)
    {
        if (playerLife > 24)
        {
            playerLife -= dano;
        }
        
        else
        {
            Destroy(player);
            Debug.Log("morreuuuuu");
            playerAnim.SetTrigger("death");
        }
    }


    //private void OnTriggerEnter(Collider Winne)
    //{
    //    if(Winne.CompareTag("Player"))
    //    {
    //        Debug.Log("Voce conseguiu fugir das almas");
    //        SceneManager.LoadScene(Winner);
    //    }
    //
    //    //Destroy(gameObject, 10f);
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Voce conseguiu fugir das almas");
            SceneManager.LoadScene(Winner);
        }
    }

    
}
