using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Equipables/EquipablesList")]
public class EquipablesList : ScriptableObject
{
    [SerializeField] public List<ItemEquipData> equipablesList;
}
