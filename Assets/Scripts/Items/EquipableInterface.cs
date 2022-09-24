using UnityEngine;

[System.Serializable]
public abstract class EquipableInterface : ItemInterface
{
    [SerializeReference] private ItemEquipData _itemData;
    public new ItemEquipData ItemData { get { return _itemData; } set { _itemData = value; } }

    public abstract void EquipEffect();
    public abstract void UnequipEffect();
}
