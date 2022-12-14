using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI boxText;

    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDiamondText(PlayerInventory playerInventory)
    {
        boxText.text = playerInventory.NumberOfDiamonds.ToString();
    }
}