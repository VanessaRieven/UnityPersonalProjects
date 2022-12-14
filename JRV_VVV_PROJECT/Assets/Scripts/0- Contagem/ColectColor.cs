using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//= Diamont
public class ColectColor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.DiamondCollected();
            //gameObject.SetActive(false);
        }
    }
}
