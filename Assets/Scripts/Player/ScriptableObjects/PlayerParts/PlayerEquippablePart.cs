using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/Part/EquippablePart")]
public class PlayerEquippablePart : ScriptableObject
{
    //  Part Type
    [SerializeField] private PartType bodyPartType;
    public PartType BodyPartType { get { return bodyPartType; } }

    //  Part GameObject
    [SerializeField] private GameObject partGameObject;
    public GameObject PartGameObject { get { return partGameObject; } }

    //  Sprite
    [SerializeField] private Sprite partIcon;
    public Sprite PartIcon { get { return partIcon; } private set { partIcon = value; } }

    //  Item Equipped
    [SerializeReference] private EquipableInterface equippedItem;
    public EquipableInterface EquippedItem { get; set; }
}
