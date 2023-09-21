using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjects : MonoBehaviour
{
    public GameObject objectToON;
    public GameObject objectToOFF;
    

    private bool canToggle = false; // var para controlar a interacao
    private bool hasToggled = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canToggle = true;
        }
    }

    private void Update()
    {
        if (canToggle && Input.GetKeyDown(KeyCode.E) && !hasToggled)
        {
            // inverte a visibilidade dos objetos
            objectToON.SetActive(!objectToON.activeSelf);
            objectToOFF.SetActive(!objectToOFF.activeSelf);

            // define a variavel para impedir alternancias pelo E
            hasToggled = true;
        }
    }
}