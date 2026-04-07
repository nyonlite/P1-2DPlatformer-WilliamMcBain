using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] private ItemData type;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            InventoryManager inventory = other.GetComponent<InventoryManager>();
            if (inventory != null)
            {
                bool pickedUp = inventory.PickUp(type);
                if (pickedUp)
                {
                
                    Destroy(gameObject);
                }
            }
        }
    }


}

