using UnityEngine;

[CreateAssetMenu(menuName = "Items/BasicItemData")]
public abstract class ItemBaseData : ScriptableObject
{
    [SerializeField] private int itemID;
    [SerializeField] private string itemName;
    [SerializeField] private Sprite itemSprite;
    [SerializeField] private bool isQuest;
}
