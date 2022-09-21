using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipButton : MonoBehaviour
{
    [SerializeField] private PlayerEquippablePart part;
    [SerializeField] private EquipableInterface item;

    public void Init(PlayerEquippablePart part, EquipableInterface item)
    {
        this.part = part;
        this.item = item;
    }

    public void Equip()
    {
        part.Equip(item);
    }
}
