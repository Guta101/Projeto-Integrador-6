using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipableStatBoost : EquipableInterface
{
    public EquipableStatBoost(ItemEquipData item)
    {
        ItemData = item;
    }

    public override void EquipEffect()
    {
        for (int i = 0; i < ItemData.StatVariables.Length; i++)
        {
            ItemData.StatVariables[i].AddStatBoost(ItemData.BoostAmount[i]);
        }
    }

    public override void UnequipEffect()
    {
        for (int i = 0; i < ItemData.StatVariables.Length; i++)
        {
            ItemData.StatVariables[i].RemoveStatBoost(ItemData.BoostAmount[i]);
        }
    }
}
