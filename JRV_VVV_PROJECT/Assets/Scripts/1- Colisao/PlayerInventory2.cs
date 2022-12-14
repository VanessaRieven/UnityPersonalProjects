using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory2 : MonoBehaviour
{
    public int NumberOfDiamonds2 { get; private set; }

    public UnityEvent<PlayerInventory2> OnDiamondCollected2;

    public void DiamondCollected2()
    {
        NumberOfDiamonds2++;
        OnDiamondCollected2.Invoke(this);
    }
}
