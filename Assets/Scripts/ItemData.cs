using UnityEngine;

[CreateAssetMenu(fileName = "New Item" , menuName = "Inventory/Item")]

public class ItemData : ScriptableObject
{
    [SerializeField] private ItemType type;
    [SerializeField] private string itemName;
    //[SerializeField] private string description;
    [SerializeField] private float value;
    [SerializeField] private Sprite icon;
    //[SerializeField] private int maxStack;
    //[SerializeField] private bool isConsumable;

    public ItemType Type() { return type; }
    public string ItemName() { return itemName; } 
    //public string Description() { return description; }
    public float Value() { return value; }
    public Sprite Icon() { return icon; }
    //public int MaxStack() { return maxStack; }
    //public bool IsConsumable() { return isConsumable; }
         
}


