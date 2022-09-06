using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Equippable")]
public class ItemEquip : ItemBase
{
    //  List of possible equippable parts
    public List<PlayerEquippablePart> EquippableParts = new List<PlayerEquippablePart>();
}