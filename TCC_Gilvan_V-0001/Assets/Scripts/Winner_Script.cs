using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner_Script : MonoBehaviour
{
    [SerializeField] private string Menu;
            
    public void Menuu()
    {
        SceneManager.LoadScene(Menu);
    }

    


}
