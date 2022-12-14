using UnityEngine;
using TMPro;

public class InventoryUItotal : MonoBehaviour
{
    private TextMeshProUGUI diamondText2;

    // Start is called before the first frame update
    void Start()
    {
        diamondText2 = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDiamondText2(PlayerInventory2 playerInventory2)
    {
        diamondText2.text = playerInventory2.NumberOfDiamonds2.ToString();
    }
}