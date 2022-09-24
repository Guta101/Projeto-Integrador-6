using UnityEngine;

[System.Serializable]
public abstract class ItemInterface
{
    [SerializeReference] private ItemBaseData _itemData;

    public ItemBaseData ItemData { get { return _itemData; } set { _itemData = value; } }
}
