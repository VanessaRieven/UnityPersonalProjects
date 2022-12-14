using UnityEngine;

public class Diamond : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory2 playerInventory2 = other.GetComponent<PlayerInventory2>();

        if (playerInventory2 != null)
        {
            playerInventory2.DiamondCollected2();
            gameObject.SetActive(false);
        }
    }
}
