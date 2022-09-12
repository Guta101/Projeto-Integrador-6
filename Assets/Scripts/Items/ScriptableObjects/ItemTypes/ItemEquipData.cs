using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/EquipableData")]
public abstract class ItemEquipData : ItemBaseData
{
    //  List of possible equippable parts
    public List<PlayerEquippablePart> EquippableParts = new List<PlayerEquippablePart>();
}