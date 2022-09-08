using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemEquip : ItemBase
{
    //  List of possible equippable parts
    public List<PlayerEquippablePart> EquippableParts = new List<PlayerEquippablePart>();

    public abstract void EquipBuff();
}