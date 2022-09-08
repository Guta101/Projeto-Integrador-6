using UnityEngine;

public abstract class ItemBase : ScriptableObject
{
    [SerializeField] private int itemID;
    [SerializeField] private string itemName;
    [SerializeField] private Sprite itemSprite;
    [SerializeField] private bool isQuest;
}
