using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Equipables/Equippable")]
public class ItemEquipData : ItemBaseData
{
    //  List of possible equippable parts
    public List<PlayerEquippablePart> EquippableParts = new List<PlayerEquippablePart>();

    [SerializeField] private StatVariable[] statVariables;
    [SerializeField] private float[] boostAmount;

    public StatVariable[] StatVariables { get { return statVariables; } }
    public float[] BoostAmount { get { return boostAmount; } }
}