using UnityEngine;

public abstract class EquipableInterface : ItemInterface
{
    private ItemEquipData _itemData;
    public new ItemEquipData ItemData { get { return _itemData; } set { _itemData = value; } }

    public abstract void EquipEffect();
    public abstract void UnequipEffect();
}
