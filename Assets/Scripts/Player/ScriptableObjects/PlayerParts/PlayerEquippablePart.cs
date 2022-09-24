using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/EquippablePart")]
public class PlayerEquippablePart : ScriptableObject
{
    //  Sprite
    [SerializeField] private Sprite partIcon;
    public Sprite PartIcon { get { return partIcon; } private set { partIcon = value; } }

    //  Item Equipped
    [SerializeReference] private EquipableInterface equippedItem;
    public EquipableInterface EquippedItem { get; set; }
}
